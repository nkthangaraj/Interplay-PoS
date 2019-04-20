﻿using io.cloudloom.interplay.pos.Proxy.Contracts;
using io.cloudloom.interplay.pos.Proxy.Contracts.AllUsers;
using io.cloudloom.interplay.pos.Proxy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utility
{
    public static class AuthenticationUtility
    {
        const string AuthenticationError = "Invalid credentials, Please validate";

        private static  User user;

        public static User Authenticate(Credential credential)
        {
            string errorMessage = string.Empty;

            try
            {
                UserService userService = new UserService(credential);
                return user= userService.GetProfile();
            }
            catch (Exception ex)
            {
                errorMessage = AuthenticationError;
            }

            return null;
        }
    }
}
