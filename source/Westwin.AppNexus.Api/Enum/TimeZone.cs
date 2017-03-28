using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum TimeZone : int
    {

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Abidjan")]
        AfricaAbidjan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Accra")]
        AfricaAccra,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Addis_Ababa")]
        AfricaAddisAbaba,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Algiers")]
        AfricaAlgiers,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Asmara")]
        AfricaAsmara,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Asmera")]
        AfricaAsmera,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Bamako")]
        AfricaBamako,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Bangui")]
        AfricaBangui,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Banjul")]
        AfricaBanjul,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Bissau")]
        AfricaBissau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Blantyre")]
        AfricaBlantyre,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Brazzaville")]
        AfricaBrazzaville,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Bujumbura")]
        AfricaBujumbura,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Cairo")]
        AfricaCairo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Casablanca")]
        AfricaCasablanca,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Ceuta")]
        AfricaCeuta,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Conakry")]
        AfricaConakry,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Dakar")]
        AfricaDakar,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Dar_es_Salaam")]
        AfricaDarEsSalaam,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Djibouti")]
        AfricaDjibouti,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Douala")]
        AfricaDouala,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/El_Aaiun")]
        AfricaElAaiun,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Freetown")]
        AfricaFreetown,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Gaborone")]
        AfricaGaborone,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Harare")]
        AfricaHarare,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Johannesburg")]
        AfricaJohannesburg,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Kampala")]
        AfricaKampala,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Khartoum")]
        AfricaKhartoum,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Kigali")]
        AfricaKigali,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Kinshasa")]
        AfricaKinshasa,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Lagos")]
        AfricaLagos,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Libreville")]
        AfricaLibreville,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Lome")]
        AfricaLome,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Luanda")]
        AfricaLuanda,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Lubumbashi")]
        AfricaLubumbashi,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Lusaka")]
        AfricaLusaka,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Malabo")]
        AfricaMalabo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Maputo")]
        AfricaMaputo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Maseru")]
        AfricaMaseru,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Mbabane")]
        AfricaMbabane,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Mogadishu")]
        AfricaMogadishu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Monrovia")]
        AfricaMonrovia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Nairobi")]
        AfricaNairobi,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Ndjamena")]
        AfricaNdjamena,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Niamey")]
        AfricaNiamey,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Nouakchott")]
        AfricaNouakchott,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Ouagadougou")]
        AfricaOuagadougou,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Porto-Novo")]
        AfricaPortoNovo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Sao_Tome")]
        AfricaSaoTome,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Timbuktu")]
        AfricaTimbuktu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Tripoli")]
        AfricaTripoli,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Tunis")]
        AfricaTunis,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Windhoek")]
        AfricaWindhoek,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Adak")]
        AmericaAdak,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Anchorage")]
        AmericaAnchorage,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Anguilla")]
        AmericaAnguilla,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Antigua")]
        AmericaAntigua,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Araguaina")]
        AmericaAraguaina,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Catamarca")]
        AmericaArgentinaCatamarca,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/ComodRivadavia")]
        AmericaArgentinaComodRivadavia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Cordoba")]
        AmericaArgentinaCordoba,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Jujuy")]
        AmericaArgentinaJujuy,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/La_Rioja")]
        AmericaArgentinaLaRioja,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Mendoza")]
        AmericaArgentinaMendoza,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Rio_Gallegos")]
        AmericaArgentinaRioGallegos,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Salta")]
        AmericaArgentinaSalta,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/San_Juan")]
        AmericaArgentinaSanJuan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/San_Luis")]
        AmericaArgentinaSanLuis,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Tucuman")]
        AmericaArgentinaTucuman,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Ushuaia")]
        AmericaArgentinaUshuaia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Aruba")]
        AmericaAruba,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Asuncion")]
        AmericaAsuncion,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Atikokan")]
        AmericaAtikokan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Atka")]
        AmericaAtka,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Bahia")]
        AmericaBahia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Barbados")]
        AmericaBarbados,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Belem")]
        AmericaBelem,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Belize")]
        AmericaBelize,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Blanc-Sablon")]
        AmericaBlancSablon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Boa_Vista")]
        AmericaBoaVista,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Bogota")]
        AmericaBogota,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Boise")]
        AmericaBoise,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Buenos_Aires")]
        AmericaBuenosAires,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Cambridge_Bay")]
        AmericaCambridgeBay,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Campo_Grande")]
        AmericaCampoGrande,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Cancun")]
        AmericaCancun,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Catamarca")]
        AmericaCatamarca,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Cayenne")]
        AmericaCayenne,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Cayman")]
        AmericaCayman,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Chicago")]
        AmericaChicago,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Chihuahua")]
        AmericaChihuahua,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Coral_Harbour")]
        AmericaCoralHarbour,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Cordoba")]
        AmericaCordoba,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Costa_Rica")]
        AmericaCostaRica,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Cuiaba")]
        AmericaCuiaba,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Curacao")]
        AmericaCuracao,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Danmarkshavn")]
        AmericaDanmarkshavn,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Dawson")]
        AmericaDawson,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Dawson_Creek")]
        AmericaDawsonCreek,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Denver")]
        AmericaDenver,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Detroit")]
        AmericaDetroit,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Dominica")]
        AmericaDominica,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Edmonton")]
        AmericaEdmonton,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Eirunepe")]
        AmericaEirunepe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/El_Salvador")]
        AmericaElSalvador,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Ensenada")]
        AmericaEnsenada,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Fortaleza")]
        AmericaFortaleza,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Fort_Wayne")]
        AmericaFortWayne,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Glace_Bay")]
        AmericaGlaceBay,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Godthab")]
        AmericaGodthab,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Goose_Bay")]
        AmericaGooseBay,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Grand_Turk")]
        AmericaGrandTurk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Grenada")]
        AmericaGrenada,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Guadeloupe")]
        AmericaGuadeloupe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Guatemala")]
        AmericaGuatemala,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Guayaquil")]
        AmericaGuayaquil,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Guyana")]
        AmericaGuyana,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Halifax")]
        AmericaHalifax,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Havana")]
        AmericaHavana,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Hermosillo")]
        AmericaHermosillo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Knox")]
        AmericaIndianaKnox,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Marengo")]
        AmericaIndianaMarengo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Petersburg")]
        AmericaIndianaPetersburg,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Tell_City")]
        AmericaIndianaTellCity,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Vevay")]
        AmericaIndianaVevay,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Vincennes")]
        AmericaIndianaVincennes,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indiana/Winamac")]
        AmericaIndianaWinamac,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Indianapolis")]
        AmericaIndianapolis,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Inuvik")]
        AmericaInuvik,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Iqaluit")]
        AmericaIqaluit,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Jamaica")]
        AmericaJamaica,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Jujuy")]
        AmericaJujuy,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Juneau")]
        AmericaJuneau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Kentucky/Louisville")]
        AmericaKentuckyLouisville,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Kentucky/Monticello")]
        AmericaKentuckyMonticello,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Knox_IN")]
        AmericaKnoxIN,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/La_Paz")]
        AmericaLaPaz,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Lima")]
        AmericaLima,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Los_Angeles")]
        AmericaLosAngeles,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Louisville")]
        AmericaLouisville,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Maceio")]
        AmericaMaceio,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Managua")]
        AmericaManagua,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Manaus")]
        AmericaManaus,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Marigot")]
        AmericaMarigot,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Martinique")]
        AmericaMartinique,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Mazatlan")]
        AmericaMazatlan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Mendoza")]
        AmericaMendoza,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Menominee")]
        AmericaMenominee,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Merida")]
        AmericaMerida,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Mexico_City")]
        AmericaMexicoCity,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Miquelon")]
        AmericaMiquelon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Moncton")]
        AmericaMoncton,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Monterrey")]
        AmericaMonterrey,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Montevideo")]
        AmericaMontevideo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Montreal")]
        AmericaMontreal,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Montserrat")]
        AmericaMontserrat,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Nassau")]
        AmericaNassau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/New_York")]
        AmericaNewYork,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Nipigon")]
        AmericaNipigon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Nome")]
        AmericaNome,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Noronha")]
        AmericaNoronha,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/North_Dakota/Center")]
        AmericaNorthDakotaCenter,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/North_Dakota/New_Salem")]
        AmericaNorthDakotaNewSalem,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Panama")]
        AmericaPanama,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Pangnirtung")]
        AmericaPangnirtung,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Paramaribo")]
        AmericaParamaribo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Phoenix")]
        AmericaPhoenix,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Port-au-Prince")]
        AmericaPortAuPrince,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Porto_Acre")]
        AmericaPortoAcre,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Porto_Velho")]
        AmericaPortoVelho,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Port_of_Spain")]
        AmericaPortOfSpain,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Puerto_Rico")]
        AmericaPuertoRico,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Rainy_River")]
        AmericaRainyRiver,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Rankin_Inlet")]
        AmericaRankinInlet,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Recife")]
        AmericaRecife,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Regina")]
        AmericaRegina,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Resolute")]
        AmericaResolute,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Rio_Branco")]
        AmericaRioBranco,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Rosario")]
        AmericaRosario,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Santarem")]
        AmericaSantarem,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Santiago")]
        AmericaSantiago,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Santo_Domingo")]
        AmericaSantoDomingo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Sao_Paulo")]
        AmericaSaoPaulo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Scoresbysund")]
        AmericaScoresbysund,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Shiprock")]
        AmericaShiprock,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/St_Barthelemy")]
        AmericaStBarthelemy,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/St_Kitts")]
        AmericaStKitts,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/St_Lucia")]
        AmericaStLucia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/St_Thomas")]
        AmericaStThomas,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/St_Vincent")]
        AmericaStVincent,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Swift_Current")]
        AmericaSwiftCurrent,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Tegucigalpa")]
        AmericaTegucigalpa,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Thule")]
        AmericaThule,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Thunder_Bay")]
        AmericaThunderBay,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Tijuana")]
        AmericaTijuana,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Toronto")]
        AmericaToronto,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Tortola")]
        AmericaTortola,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Vancouver")]
        AmericaVancouver,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Virgin")]
        AmericaVirgin,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Whitehorse")]
        AmericaWhitehorse,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Winnipeg")]
        AmericaWinnipeg,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Yakutat")]
        AmericaYakutat,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Yellowknife")]
        AmericaYellowknife,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/Casey")]
        AntarcticaCasey,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/Davis")]
        AntarcticaDavis,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/DumontDUrville")]
        AntarcticaDumontDUrville,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/Mawson")]
        AntarcticaMawson,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/McMurdo")]
        AntarcticaMcMurdo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/Palmer")]
        AntarcticaPalmer,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/Rothera")]
        AntarcticaRothera,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/South_Pole")]
        AntarcticaSouthPole,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/Syowa")]
        AntarcticaSyowa,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Antarctica/Vostok")]
        AntarcticaVostok,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Arctic/Longyearbyen")]
        ArcticLongyearbyen,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Aden")]
        AsiaAden,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Almaty")]
        AsiaAlmaty,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Amman")]
        AsiaAmman,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Anadyr")]
        AsiaAnadyr,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Aqtau")]
        AsiaAqtau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Aqtobe")]
        AsiaAqtobe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Ashgabat")]
        AsiaAshgabat,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Ashkhabad")]
        AsiaAshkhabad,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Baghdad")]
        AsiaBaghdad,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Bahrain")]
        AsiaBahrain,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Baku")]
        AsiaBaku,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Bangkok")]
        AsiaBangkok,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Beirut")]
        AsiaBeirut,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Bishkek")]
        AsiaBishkek,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Brunei")]
        AsiaBrunei,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Calcutta")]
        AsiaCalcutta,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Choibalsan")]
        AsiaChoibalsan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Chongqing")]
        AsiaChongqing,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Chungking")]
        AsiaChungking,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Colombo")]
        AsiaColombo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Dacca")]
        AsiaDacca,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Damascus")]
        AsiaDamascus,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Dhaka")]
        AsiaDhaka,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Dili")]
        AsiaDili,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Dubai")]
        AsiaDubai,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Dushanbe")]
        AsiaDushanbe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Gaza")]
        AsiaGaza,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Harbin")]
        AsiaHarbin,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Hong_Kong")]
        AsiaHongKong,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Hovd")]
        AsiaHovd,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Irkutsk")]
        AsiaIrkutsk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Istanbul")]
        AsiaIstanbul,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Jakarta")]
        AsiaJakarta,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Jayapura")]
        AsiaJayapura,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Jerusalem")]
        AsiaJerusalem,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Kamchatka")]
        AsiaKamchatka,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Karachi")]
        AsiaKarachi,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Kashgar")]
        AsiaKashgar,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Kathmandu")]
        AsiaKathmandu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Kuching")]
        AsiaKuching,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Kuwait")]
        AsiaKuwait,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Macao")]
        AsiaMacao,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Macau")]
        AsiaMacau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Magadan")]
        AsiaMagadan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Makassar")]
        AsiaMakassar,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Manila")]
        AsiaManila,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Muscat")]
        AsiaMuscat,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Nicosia")]
        AsiaNicosia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Novosibirsk")]
        AsiaNovosibirsk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Omsk")]
        AsiaOmsk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Oral")]
        AsiaOral,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Phnom_Penh")]
        AsiaPhnomPenh,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Pontianak")]
        AsiaPontianak,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Pyongyang")]
        AsiaPyongyang,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Qatar")]
        AsiaQatar,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Qyzylorda")]
        AsiaQyzylorda,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Rangoon")]
        AsiaRangoon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Riyadh")]
        AsiaRiyadh,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Saigon")]
        AsiaSaigon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Sakhalin")]
        AsiaSakhalin,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Samarkand")]
        AsiaSamarkand,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Seoul")]
        AsiaSeoul,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Shanghai")]
        AsiaShanghai,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Singapore")]
        AsiaSingapore,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Taipei")]
        AsiaTaipei,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Tashkent")]
        AsiaTashkent,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Tbilisi")]
        AsiaTbilisi,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Tel_Aviv")]
        AsiaTelAviv,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Thimbu")]
        AsiaThimbu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Thimphu")]
        AsiaThimphu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Tokyo")]
        AsiaTokyo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Ujung_Pandang")]
        AsiaUjungPandang,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Ulaanbaatar")]
        AsiaUlaanbaatar,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Ulan_Bator")]
        AsiaUlanBator,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Urumqi")]
        AsiaUrumqi,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Vientiane")]
        AsiaVientiane,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Vladivostok")]
        AsiaVladivostok,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Yakutsk")]
        AsiaYakutsk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Yekaterinburg")]
        AsiaYekaterinburg,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Yerevan")]
        AsiaYerevan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Azores")]
        AtlanticAzores,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Bermuda")]
        AtlanticBermuda,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Canary")]
        AtlanticCanary,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Cape_Verde")]
        AtlanticCapeVerde,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Faeroe")]
        AtlanticFaeroe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Faroe")]
        AtlanticFaroe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Jan_Mayen")]
        AtlanticJanMayen,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Madeira")]
        AtlanticMadeira,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Reykjavik")]
        AtlanticReykjavik,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Stanley")]
        AtlanticStanley,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/St_Helena")]
        AtlanticStHelena,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/ACT")]
        AustraliaACT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Brisbane")]
        AustraliaBrisbane,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Broken_Hill")]
        AustraliaBrokenHill,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Canberra")]
        AustraliaCanberra,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Currie")]
        AustraliaCurrie,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Darwin")]
        AustraliaDarwin,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Eucla")]
        AustraliaEucla,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Hobart")]
        AustraliaHobart,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/LHI")]
        AustraliaLHI,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Lindeman")]
        AustraliaLindeman,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Lord_Howe")]
        AustraliaLordHowe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Melbourne")]
        AustraliaMelbourne,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/North")]
        AustraliaNorth,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/NSW")]
        AustraliaNSW,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Perth")]
        AustraliaPerth,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Queensland")]
        AustraliaQueensland,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/South")]
        AustraliaSouth,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Sydney")]
        AustraliaSydney,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Tasmania")]
        AustraliaTasmania,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Victoria")]
        AustraliaVictoria,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/West")]
        AustraliaWest,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Yancowinna")]
        AustraliaYancowinna,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Brazil/Acre")]
        BrazilAcre,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Brazil/DeNoronha")]
        BrazilDeNoronha,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Brazil/East")]
        BrazilEast,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Brazil/West")]
        BrazilWest,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Atlantic")]
        CanadaAtlantic,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Central")]
        CanadaCentral,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/East-Saskatchewan")]
        CanadaEastSaskatchewan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Eastern")]
        CanadaEastern,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Mountain")]
        CanadaMountain,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Newfoundland")]
        CanadaNewfoundland,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Pacific")]
        CanadaPacific,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Saskatchewan")]
        CanadaSaskatchewan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Canada/Yukon")]
        CanadaYukon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("CET")]
        CET,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Chile/Continental")]
        ChileContinental,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Chile/EasterIsland")]
        ChileEasterIsland,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("CST6CDT")]
        CST6CDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Cuba")]
        Cuba,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("EET")]
        EET,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Egypt")]
        Egypt,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Eire")]
        Eire,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("EST")]
        EST,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("EST5EDT")]
        EST5EDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT")]
        EtcGMT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+0")]
        EtcGMT0,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+1")]
        EtcGMTAdd1,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+10")]
        EtcGMTAdd10,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+11")]
        EtcGMTAdd11,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+12")]
        EtcGMTAdd12,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+2")]
        EtcGMTAdd2,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+3")]
        EtcGMTAdd3,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+4")]
        EtcGMTAdd4,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+5")]
        EtcGMTAdd5,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+6")]
        EtcGMTAdd6,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+7")]
        EtcGMTAdd7,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+8")]
        EtcGMTAdd8,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT+9")]
        EtcGMTAdd9,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-0")]
        EtcGMTMinus0,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-1")]
        EtcGMTMinus1,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-10")]
        EtcGMTMinus10,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-11")]
        EtcGMTMinus11,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-12")]
        EtcGMTMinus12,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-13")]
        EtcGMTMinus13,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-2")]
        EtcGMTMinus2,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-3")]
        EtcGMTMinus3,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-4")]
        EtcGMTMinus4,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-5")]
        EtcGMTMinus5,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-6")]
        EtcGMTMinus6,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-7")]
        EtcGMTMinus7,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-8")]
        EtcGMTMinus8,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/GMT-9")]
        EtcGMTMinus9,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/Greenwich")]
        EtcGreenwich,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/UCT")]
        EtcUCT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/Universal")]
        EtcUniversal,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/UTC")]
        EtcUTC,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Etc/Zulu")]
        EtcZulu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Amsterdam")]
        EuropeAmsterdam,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Andorra")]
        EuropeAndorra,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Athens")]
        EuropeAthens,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Belfast")]
        EuropeBelfast,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Belgrade")]
        EuropeBelgrade,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Berlin")]
        EuropeBerlin,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Bratislava")]
        EuropeBratislava,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Brussels")]
        EuropeBrussels,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Bucharest")]
        EuropeBucharest,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Budapest")]
        EuropeBudapest,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Chisinau")]
        EuropeChisinau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Copenhagen")]
        EuropeCopenhagen,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Dublin")]
        EuropeDublin,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Gibraltar")]
        EuropeGibraltar,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Guernsey")]
        EuropeGuernsey,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Helsinki")]
        EuropeHelsinki,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Isle_of_Man")]
        EuropeIsleOfMan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Istanbul")]
        EuropeIstanbul,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Jersey")]
        EuropeJersey,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Kaliningrad")]
        EuropeKaliningrad,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Kiev")]
        EuropeKiev,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Lisbon")]
        EuropeLisbon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Ljubljana")]
        EuropeLjubljana,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/London")]
        EuropeLondon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Luxembourg")]
        EuropeLuxembourg,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Madrid")]
        EuropeMadrid,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Malta")]
        EuropeMalta,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Mariehamn")]
        EuropeMariehamn,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Minsk")]
        EuropeMinsk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Monaco")]
        EuropeMonaco,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Moscow")]
        EuropeMoscow,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Nicosia")]
        EuropeNicosia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Oslo")]
        EuropeOslo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Paris")]
        EuropeParis,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Podgorica")]
        EuropePodgorica,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Prague")]
        EuropePrague,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Riga")]
        EuropeRiga,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Rome")]
        EuropeRome,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Samara")]
        EuropeSamara,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/San_Marino")]
        EuropeSanMarino,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Sarajevo")]
        EuropeSarajevo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Simferopol")]
        EuropeSimferopol,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Skopje")]
        EuropeSkopje,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Sofia")]
        EuropeSofia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Stockholm")]
        EuropeStockholm,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Tallinn")]
        EuropeTallinn,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Tirane")]
        EuropeTirane,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Tiraspol")]
        EuropeTiraspol,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Uzhgorod")]
        EuropeUzhgorod,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Vaduz")]
        EuropeVaduz,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Vatican")]
        EuropeVatican,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Vienna")]
        EuropeVienna,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Vilnius")]
        EuropeVilnius,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Volgograd")]
        EuropeVolgograd,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Warsaw")]
        EuropeWarsaw,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Zagreb")]
        EuropeZagreb,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Zaporozhye")]
        EuropeZaporozhye,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Zurich")]
        EuropeZurich,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Factory")]
        Factory,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("GB")]
        GB,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("GB-Eire")]
        GBEire,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("GMT")]
        GMT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("GMT+0")]
        GMT0,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Greenwich")]
        Greenwich,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Hongkong")]
        Hongkong,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("HST")]
        HST,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Iceland")]
        Iceland,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Antananarivo")]
        IndianAntananarivo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Chagos")]
        IndianChagos,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Christmas")]
        IndianChristmas,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Comoro")]
        IndianComoro,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Kerguelen")]
        IndianKerguelen,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Mahe")]
        IndianMahe,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Maldives")]
        IndianMaldives,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Mauritius")]
        IndianMauritius,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Mayotte")]
        IndianMayotte,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Reunion")]
        IndianReunion,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Iran")]
        Iran,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Israel")]
        Israel,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Jamaica")]
        Jamaica,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Japan")]
        Japan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Kwajalein")]
        Kwajalein,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Libya")]
        Libya,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("MET")]
        MET,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Mexico/BajaNorte")]
        MexicoBajaNorte,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Mexico/BajaSur")]
        MexicoBajaSur,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Mexico/General")]
        MexicoGeneral,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("MST")]
        MST,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("MST7MDT")]
        MST7MDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Navajo")]
        Navajo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("NZ")]
        NZ,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("NZ-CHAT")]
        NZCHAT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Apia")]
        PacificApia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Auckland")]
        PacificAuckland,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Chatham")]
        PacificChatham,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Easter")]
        PacificEaster,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Efate")]
        PacificEfate,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Enderbury")]
        PacificEnderbury,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Fakaofo")]
        PacificFakaofo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Fiji")]
        PacificFiji,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Funafuti")]
        PacificFunafuti,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Galapagos")]
        PacificGalapagos,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Gambier")]
        PacificGambier,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Guadalcanal")]
        PacificGuadalcanal,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Guam")]
        PacificGuam,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Honolulu")]
        PacificHonolulu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Johnston")]
        PacificJohnston,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Kosrae")]
        PacificKosrae,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Kwajalein")]
        PacificKwajalein,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Majuro")]
        PacificMajuro,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Marquesas")]
        PacificMarquesas,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Midway")]
        PacificMidway,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Nauru")]
        PacificNauru,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Niue")]
        PacificNiue,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Norfolk")]
        PacificNorfolk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Noumea")]
        PacificNoumea,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Pago_Pago")]
        PacificPagoPago,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Palau")]
        PacificPalau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Pitcairn")]
        PacificPitcairn,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Ponape")]
        PacificPonape,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Port_Moresby")]
        PacificPortMoresby,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Rarotonga")]
        PacificRarotonga,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Saipan")]
        PacificSaipan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Samoa")]
        PacificSamoa,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Tahiti")]
        PacificTahiti,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Tarawa")]
        PacificTarawa,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Tongatapu")]
        PacificTongatapu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Truk")]
        PacificTruk,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Wake")]
        PacificWake,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Wallis")]
        PacificWallis,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Yap")]
        PacificYap,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Poland")]
        Poland,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Portugal")]
        Portugal,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("PRC")]
        PRC,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("PST8PDT")]
        PST8PDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("ROC")]
        ROC,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("ROK")]
        ROK,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Singapore")]
        Singapore,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Turkey")]
        Turkey,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("UCT")]
        UCT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Universal")]
        Universal,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Alaska")]
        USAlaska,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Aleutian")]
        USAleutian,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Arizona")]
        USArizona,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Central")]
        USCentral,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/East-Indiana")]
        USEastIndiana,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Eastern")]
        USEastern,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Hawaii")]
        USHawaii,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Indiana-Starke")]
        USIndianaStarke,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Michigan")]
        USMichigan,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Mountain")]
        USMountain,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Pacific")]
        USPacific,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("US/Samoa")]
        USSamoa,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("UTC")]
        UTC,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("W-SU")]
        WSU,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("WET")]
        WET,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Zulu")]
        Zulu,
    }
}