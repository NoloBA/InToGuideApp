
using InToGuideApp.Services.Interfaces;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using InToGuideWebAPI.Models;

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

        public async Task<User> CreateNewUser(int accountType, string firstName, string lastName, string qualification, string institution, string city, string province, string hobbies, string idNumber, string profession, string company, string phoneNumber, string emailAddress, string password, DateTime date)
        { 

            Uri uri = new Uri(_config.InToGuideServerUrl + "api/User");

              var model = new User()
               {
                   AccountType = accountType,
                   FirstName = firstName,
                   LastName = lastName,
                   Qualification = qualification,
                   Institution = institution,
                   City = city,
                   Province = province,
                   Hobbies = hobbies,
                   IdNumber = idNumber,
                   Profession = profession,
                   Company = company,
                   PhoneNumber = phoneNumber,
                   EmailAddress = emailAddress,
                   Password = password,
                  Date = date,
               };

            var authentication = new Authentication();
            authentication.EmailAddress = emailAddress;
            authentication.Password = password;
            //authentication.Enabled = true;
            authentication.VerificationStatus = true;

            model.Authentication = authentication;


 
                var json = JsonConvert.SerializeObject(model);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");


            HttpResponseMessage response = null;
            response = await _httpClient.PostAsync(uri, content);


            if (response.IsSuccessStatusCode)
            {
                var contentResponse = await response.Content.ReadAsStringAsync();

                var user = JsonConvert.DeserializeObject<User>(contentResponse);

                return user;

            }

            return null;
        }

    }
}
