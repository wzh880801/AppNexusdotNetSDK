using System;
using System.Threading.Tasks;
using SimpleWebRequestHelper;
using SimpleWebRequestHelper.Entity;

namespace Westwin.AppNexus.Api
{
    /// <summary>
    /// Premium Api Client
    /// <para>This client could handle the NOAUTH error and automatically retry.</para>
    /// </summary>
    public class PremiumAppNexusApiClient : DefaultAppNexusApiClient
    {
        /// <summary>
        /// If you use an external AuthToken provider, you can just use the default instance. 
        /// <para>In this case, you should add an event for <see cref="AcquireTokenByUserName"/> and specify the <see cref="UserName"/> property.</para>
        /// <para>This is designed for the one who has multiple clients that share the same authentication profile.</para>
        /// </summary>
        public PremiumAppNexusApiClient()
            : base()
        {

        }

        /// <summary>
        /// If you want to use the client to get the Authentication Token by yourself, then you can use this instance.
        /// <para>The client will acquire the token from AppNexus server and refresh the token once it reached the expiration time.</para>
        /// <para>If you want to do something (e.g. The token successfully returned by AppNexus), you could add the event for <see cref="TokenGrantedCallback"/>.</para>
        /// <para>If you want to do something (e.g. Post the new token to the server), you could add the event for <see cref="TokenRefreshedCallback"/>.</para>
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public PremiumAppNexusApiClient(string username, string password) 
            : this()
        {
            this.UserName = username;
            this.Password = password;
        }

        private string _token = null;
        private DateTime _tokenExpiresTime = DateTime.Now;
        private DateTime _tokenHardExpiresTime = DateTime.Now;

        public string UserName { get; set; }
        public string Password { get; set; }

        #region event
        
        /// <summary>
        /// Token refresh callback
        /// </summary>
        /// <param name="username"></param>
        /// <param name="oldToken"></param>
        /// <param name="newToken"></param>
        public delegate void TokenRefreshedCallbackHandler(string username, string oldToken, string newToken);

        /// <summary>
        /// Fires when an token was successfully granted
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newToken"></param>
        public delegate void TokenGrantedCallbackHandler(string username, string newToken);

        /// <summary>
        /// If you want to acquire an token by yourself, then you can use this handler
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public delegate string AcquireTokenHandler(string username);

        private event TokenRefreshedCallbackHandler _tokenRefreshedCallback = null;

        /// <summary>
        /// Fires when an new token was successfully refreshed
        /// </summary>
        public event TokenRefreshedCallbackHandler TokenRefreshedCallback
        {
            add
            {
                _tokenRefreshedCallback += value;
            }
            remove
            {
                _tokenRefreshedCallback -= value;
            }
        }

        private event TokenGrantedCallbackHandler _tokenGrantedCallBack = null;

        /// <summary>
        /// Fires when an token was successfully granted
        /// </summary>
        public event TokenGrantedCallbackHandler TokenGrantedCallback
        {
            add
            {
                this._tokenGrantedCallBack += value;
            }
            remove
            {
                this._tokenGrantedCallBack -= value;
            }
        }

        private event AcquireTokenHandler _acquireTokenHandler = null;
        
        /// <summary>
        /// Add this event if you want to acquire an token by yourself
        /// </summary>
        public event AcquireTokenHandler AcquireTokenByUserName
        {
            add
            {
                this._acquireTokenHandler += value;
            }
            remove
            {
                this._acquireTokenHandler -= value;
            }
        }

        #endregion

        protected bool Connect()
        {
            if (this._acquireTokenHandler != null)
            {
                this._token = this._acquireTokenHandler(this.UserName);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(_token))
                {
                    // Internal auth provider
                    // Use username and password for auth
                    Login();
                }
                else if (_tokenExpiresTime <= DateTime.Now)
                {
                    //expired
                    //re-auth
                    ReAuth();
                }
            }
            return true;
        }

        protected bool Login()
        {
            if (string.IsNullOrWhiteSpace(this.UserName) || string.IsNullOrWhiteSpace(this.Password))
                throw new Exception("UserName or Password can not be null!");

            var request = new Entity.AuthenticationRequest
            {
                UserName = this.UserName,
                Password = this.Password
            };
            var response = base.Execute(request);
            if (response != null && response.Response != null && response.Response.Status == "OK")
            {
                _token = response.Response.Token;
                _tokenExpiresTime = DateTime.Now.AddHours(2).AddMinutes(-5);
                _tokenHardExpiresTime = DateTime.Now.AddHours(24).AddMinutes(-5);

                if (_tokenGrantedCallBack != null)
                    _tokenGrantedCallBack(this.UserName, _token);

                return true;
            }
            else if (response == null || response.Response == null)
            {
                throw new Exception("Login failed! Invalid response.");
            }
            else
            {
                throw new Exception(
                    string.Format("Login failed! ErrorId: {0} ErrorMsg: {1} ErrorCode: {2} ErrorDescription: {3}",
                        response.Response.ErrorId,
                        response.Response.ErrorMessage,
                        response.Response.ErrorCode,
                        response.Response.ErrorDescription));
            }
        }

        protected bool ReAuth()
        {
            string oldToken = _token;

            Login();

            if (this._tokenRefreshedCallback != null)
                this._tokenRefreshedCallback(this.UserName, oldToken, _token);

            return true;
        }

        public override T Execute<T>(SimpleWebRequest<T> request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var objType = request.GetType();
            if (objType == typeof(Entity.AuthenticationRequest))
                return base.Execute<T>(request);

            Connect();

            //Append Authorization token in the Http Headers
            //if (request.Headers.ContainsKey("Authorization"))
            //    request.Headers["Authorization"] = _token;
            //else
            //    request.Headers.Add("Authorization", _token);
            var tokenPro = objType.GetProperty("AuthorizationToken");
            if (tokenPro != null && tokenPro.CanWrite)
                tokenPro.SetValue(request, _token);

            //Get Response
            var response = base.Execute(request);
            if (response != null)
            {
                var _apiResponse = response.GetType().GetProperty("Response");
                if (_apiResponse != null)
                {
                    var responseBody = _apiResponse.GetValue(response);
                    var pro = responseBody.GetType().GetProperty("ErrorId");
                    var errorId = pro.GetValue(responseBody);
                    if (responseBody != null && pro != null && errorId != null && errorId.ToString() == "NOAUTH")
                    {
                        //re-auth
                        ReAuth();

                        return this.Execute(request);
                    }
                }
            }

            return response;
        }

        public override T ExecuteDownload<T>(SimpleWebRequest<T> request, string fileSaveFullPath)
        {
            Connect();

            var tokenPro = request.GetType().GetProperty("AuthorizationToken");
            if (tokenPro != null && tokenPro.CanWrite)
                tokenPro.SetValue(request, _token);

            var t = base.ExecuteDownload<T>(request, fileSaveFullPath);
            if(t.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                ReAuth();

                return this.ExecuteDownload(request, fileSaveFullPath);
            }

            return t;
        }

        public override async Task<T> ExecuteAsync<T>(SimpleWebRequest<T> request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var objType = request.GetType();
            if (objType == typeof(Entity.AuthenticationRequest))
                return await base.ExecuteAsync<T>(request);

            await ConnectAsync();

            //Append Authorization token in the Http Headers
            //if (request.Headers.ContainsKey("Authorization"))
            //    request.Headers["Authorization"] = _token;
            //else
            //    request.Headers.Add("Authorization", _token);
            var tokenPro = objType.GetProperty("AuthorizationToken");
            if (tokenPro != null && tokenPro.CanWrite)
                tokenPro.SetValue(request, _token);

            //Get Response
            var response = await base.ExecuteAsync(request);
            if (response != null)
            {
                var _apiResponse = response.GetType().GetProperty("Response");
                if (_apiResponse != null)
                {
                    var responseBody = _apiResponse.GetValue(response);
                    var pro = responseBody.GetType().GetProperty("ErrorId");
                    var errorId = pro.GetValue(responseBody);
                    if (responseBody != null && pro != null && errorId != null && errorId.ToString() == "NOAUTH")
                    {
                        //re-auth
                        await ReAuthAsync();

                        return await this.ExecuteAsync(request);
                    }
                }
            }

            return response;
        }

        public override async Task<T> ExecuteDownloadAsync<T>(SimpleWebRequest<T> request, string fileSaveFullPath)
        {
            await ConnectAsync();

            var tokenPro = request.GetType().GetProperty("AuthorizationToken");
            if (tokenPro != null && tokenPro.CanWrite)
                tokenPro.SetValue(request, _token);

            var t = await base.ExecuteDownloadAsync<T>(request, fileSaveFullPath);
            if(t.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                ReAuth();

                return await this.ExecuteDownloadAsync(request, fileSaveFullPath);
            }

            return t;
        }

        protected async Task<bool> ConnectAsync()
        {
            if (this._acquireTokenHandler != null)
            {
                this._token = this._acquireTokenHandler(this.UserName);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(_token))
                {
                    // Internal auth provider
                    // Use username and password for auth
                    await LoginAsync();
                }
                else if (_tokenExpiresTime <= DateTime.Now)
                {
                    //expired
                    //re-auth
                    await ReAuthAsync();
                }
            }
            return true;
        }

        protected async Task<bool> LoginAsync()
        {
            if (string.IsNullOrWhiteSpace(this.UserName) || string.IsNullOrWhiteSpace(this.Password))
                throw new Exception("UserName or Password can not be null!");

            var request = new Entity.AuthenticationRequest
            {
                UserName = this.UserName,
                Password = this.Password
            };
            var response = await base.ExecuteAsync(request);
            if (response != null && response.Response != null && response.Response.Status == "OK")
            {
                _token = response.Response.Token;
                _tokenExpiresTime = DateTime.Now.AddHours(2).AddMinutes(-5);
                _tokenHardExpiresTime = DateTime.Now.AddHours(24).AddMinutes(-5);

                if (_tokenGrantedCallBack != null)
                    _tokenGrantedCallBack(this.UserName, _token);

                return true;
            }
            else if (response == null || response.Response == null)
            {
                throw new Exception("Login failed! Invalid response.");
            }
            else
            {
                throw new Exception(
                    string.Format("Login failed! ErrorId: {0} ErrorMsg: {1} ErrorCode: {2} ErrorDescription: {3}",
                        response.Response.ErrorId,
                        response.Response.ErrorMessage,
                        response.Response.ErrorCode,
                        response.Response.ErrorDescription));
            }
        }

        protected async Task<bool> ReAuthAsync()
        {
            string oldToken = _token;

            await LoginAsync();

            if (this._tokenRefreshedCallback != null)
                this._tokenRefreshedCallback(this.UserName, oldToken, _token);

            return true;
        }
    }
}