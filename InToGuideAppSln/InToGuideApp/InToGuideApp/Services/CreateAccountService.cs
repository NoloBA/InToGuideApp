
using InToGuideApp.Services.Interfaces;
using InToGuideWebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InToGuideApp.Services
{
    public class CreateAccountService : ICreateAccount
    {
        private HttpClient _httpClient;
        private IAppConfiguration _config;

        public CreateAccountService(IAppConfiguration config, IHttpNativeHandler handler)
        {
            _httpClient = new HttpClient(handler.GetHttpClientHandler());
            _config = config;
        }


        //    public async Task<bool> CreateNewUser(/*int accountType,*/ string firstName, string lastName, string qualification, string institution, string city, string province, string hobbies, string phoneNumber, string emailAddress, string password)
        //    {

        //        Uri uri = new Uri(_config.InToGuideServerUrl + "api/User");


        //            var request = new InToGuideWebAPI.Models.User {/* AccountType = accountType, */
        //                                       FirstName = firstName, 
        //                                       LastName = lastName, 
        //                                       Qualification = qualification, 
        //                                       Institution = institution, 
        //                                       City = city, 
        //                                       Province = province, 
        //                                       Hobbies = hobbies, 
        //                                       PhoneNumber = phoneNumber, 
        //                                       EmailAddress = emailAddress, 
        //                                       Password = password };

        //            string requestJson = JsonConvert.SerializeObject(request);

        //            StringContent content = new StringContent(requestJson, Encoding.UTF8, "application/json");

        //            HttpResponseMessage response = null;
        //            response = await _httpClient.PostAsync(uri, content);


        //            if (response.IsSuccessStatusCode)
        //            {
        //            var contentResponse = await response.Content.ReadAsStringAsync();

        //            var valueResponse = JsonConvert.DeserializeObject<bool>(contentResponse);

        //            return valueResponse;
        //        }

        //        return false;
        //    }
        //}
        public async Task<bool> CreateNewUserAsync(string accountType, string firstName, string lastName, string qualification, string institution, string city, string province, string hobbies, string phoneNumber, string emailAddress, string password)
        {
            Uri uri = new Uri(_config.InToGuideServerUrl + "api/User");
            bool Response = false;
            await Task.Run(() =>
            {
                //var client = new HttpClient();
                var model = new Models.User
                {
                    AccountType = accountType,
                    FirstName = firstName,
                    LastName = lastName,
                    Qualification = qualification,
                    Institution = institution,
                    City = city,
                    Province = province,
                    Hobbies = hobbies,
                    PhoneNumber = phoneNumber,
                    EmailAddress = emailAddress,
                    Password = password
                };
                var json = JsonConvert.SerializeObject(model);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
               
                var response = _httpClient.PostAsync( uri, content);
                var mystring = response.GetAwaiter().GetResult();

                if (response.Result.IsSuccessStatusCode)
                {
                    Response = true;
                }

            });
            return Response;
        }
    }
}
