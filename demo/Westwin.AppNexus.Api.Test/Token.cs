using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Westwin.AppNexus.Api.Test
{
    public class Token
    {
        public string UserName { get; set; }

        public string AuthenticationToken { get; set; }

        public DateTime ExpiresTime { get; set; }
    }

    public class TokenHelper
    {
        private static string _tokenFile = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "token.json");

        public static Token ReadToken()
        {
            if (!File.Exists(_tokenFile))
                return null;

            return JsonConvert.DeserializeObject<Token>(File.ReadAllText(_tokenFile));
        }

        public static void UpdateToken(Token token)
        {
            File.WriteAllText(_tokenFile, JsonConvert.SerializeObject(token));
        }
    }
}
