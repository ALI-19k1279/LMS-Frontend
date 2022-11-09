using LMS.DTOS.Users;
using LMS.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LMS.Services.Classes
{
    public class ClassService:IClassService
    {
        private HttpClient _httpClient;
        public virtual System.Net.CookieCollection Cookies { get; set; }
        public ClassService() { _httpClient = new HttpClient(); }
        public async Task<List<Class>> GetClasses(string tokenvalue)
        {
            Console.WriteLine(tokenvalue);
            string url = GlobalInfo.getClassUrl;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",tokenvalue);
            List<Class> resp = await _httpClient.GetFromJsonAsync<List<Class>>(url);
       

            //var content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(resp);
            return resp;
        }
     }
}
