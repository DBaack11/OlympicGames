using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGames.Models
{
    public class OlympicCookies
    {
        private const string MyCountries = "mycountries";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public OlympicCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }
        public OlympicCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyCountryIds(List<Country> mycountries)
        {
            List<string> ids = mycountries.Select(t => t.CountryID).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            RemoveMyCountryIds();
            responseCookies.Append(MyCountries, idsString, options);
        }

        public string[] GetMyCountryIds()
        {
            string cookie = requestCookies[MyCountries];
            if (string.IsNullOrEmpty(cookie))
            {
                return new string[] { };
            }
            else
            {
                return cookie.Split(Delimiter);
            }
        }

        public void RemoveMyCountryIds(){
            responseCookies.Delete(MyCountries);
        }

    }

}

   

