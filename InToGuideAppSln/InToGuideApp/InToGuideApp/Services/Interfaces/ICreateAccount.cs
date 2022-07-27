using InToGuideWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InToGuideApp.Services.Interfaces
{
   public interface ICreateAccount
    {
        Task<User> CreateNewUser(int accoutType, string firstName, string lastName, string qualification, string institution, string city, string province, string hobbies, string phoneNumber, string emailAddress, string password, DateTime date);
    }
}
