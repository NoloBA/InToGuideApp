
using InToGuideApp.Services.Interfaces;
using InToGuideApp.Models;
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


    //    public async Task<bool> CreateNewUser(string accountType, string firstName, string lastName, string qualification, string institution, string city, string province, string hobbies, string phoneNumber, string emailAddress, string password)
    //    {

    //        Uri uri = new Uri(_config.InToGuideServerUrl + "api/User");


    //        var request = new User()
    //        {
    //            AccountType = accountType,
    //            FirstName = firstName,
    //            LastName = lastName,
    //            Qualification = qualification,
    //            Institution = institution,
    //            City = city,
    //            Province = province,
    //            Hobbies = hobbies,
    //            PhoneNumber = phoneNumber,
    //            EmailAddress = emailAddress,
    //            Password = password
    //        };

    //        string requestJson = JsonConvert.SerializeObject(request);

    //        StringContent content = new StringContent(requestJson, Encoding.UTF8, "application/json");

    //        HttpResponseMessage response = null;
    //        response = await _httpClient.PostAsync(uri, content);


    //        if (response.IsSuccessStatusCode)
    //        {
    //            var contentResponse = await response.Content.ReadAsStringAsync();

    //            var valueResponse = JsonConvert.DeserializeObject<bool>(contentResponse);

    //            return valueResponse;
    //        }

    //        return true;
    //    }
    //}
    public async Task<User> CreateNewUser(int accountType, string firstName, string lastName, string qualification, string institution, string city, string province, string hobbies, string phoneNumber, string emailAddress, string password)
    {
            //if (string.IsNullOrEmpty(firstName))
            //{
            //    throw new ArgumentException($"'{nameof(firstName)}' cannot be null or empty.", nameof(firstName));
            //}

            //if (string.IsNullOrEmpty(lastName))
            //{
            //    throw new ArgumentException($"'{nameof(lastName)}' cannot be null or empty.", nameof(lastName));
            //}

            //if (string.IsNullOrEmpty(qualification))
            //{
            //    throw new ArgumentException($"'{nameof(qualification)}' cannot be null or empty.", nameof(qualification));
            //}

            //if (string.IsNullOrEmpty(institution))
            //{
            //    throw new ArgumentException($"'{nameof(institution)}' cannot be null or empty.", nameof(institution));
            //}

            //if (string.IsNullOrEmpty(city))
            //{
            //    throw new ArgumentException($"'{nameof(city)}' cannot be null or empty.", nameof(city));
            //}

            //if (string.IsNullOrEmpty(province))
            //{
            //    throw new ArgumentException($"'{nameof(province)}' cannot be null or empty.", nameof(province));
            //}

            //if (string.IsNullOrEmpty(hobbies))
            //{
            //    throw new ArgumentException($"'{nameof(hobbies)}' cannot be null or empty.", nameof(hobbies));
            //}

            //if (string.IsNullOrEmpty(phoneNumber))
            //{
            //    throw new ArgumentException($"'{nameof(phoneNumber)}' cannot be null or empty.", nameof(phoneNumber));
            //}

            //if (string.IsNullOrEmpty(emailAddress))
            //{
            //    throw new ArgumentException($"'{nameof(emailAddress)}' cannot be null or empty.", nameof(emailAddress));
            //}

            //if (string.IsNullOrEmpty(password))
            //{
            //    throw new ArgumentException($"'{nameof(password)}' cannot be null or empty.", nameof(password));
            //}

            Uri uri = new Uri(_config.InToGuideServerUrl + "api/User");
           // bool Response = false;

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
                   PhoneNumber = phoneNumber,
                   EmailAddress = emailAddress,
                   Password = password
               };

 
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
