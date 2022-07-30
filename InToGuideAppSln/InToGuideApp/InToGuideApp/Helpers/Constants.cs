using System;
using System.Collections.Generic;
using System.Text;

namespace InToGuideApp.Helpers
{
    public static class Constants
    {

        public static class Errors
        {
            public static string GeneralError = "Something went wrong! Please try again";
            public static string WrongEmailOrPinError = "The email or pin is incorrect"; //Login
            public static string DuplicateUserError = "User wth this email address already exists"; //Create account

            public static string UserCreateError = "Error Creating User";
        }

    }
}
