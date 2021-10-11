﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using Windows.Storage.Pickers;

namespace PhotoLibraryUWP.Model
{
    class UserManagement
    {


        //public async void UserLoginInformation()
        public List<User> UserLoginInformation()
        {
            string Filepath = $".\\Files\\UserInformation.csv";

            List<User> UserInfoList = File.ReadAllLines(Filepath)
               .Skip(1)
               .Select(user => FromCsv(user))
                .ToList();
            return (UserInfoList);

        }

        public User FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            User userinfo = new User();
            userinfo.Name = Convert.ToString(values[0]).Trim();
            userinfo.Password = Convert.ToString(values[1]).Trim();
            return userinfo;
        }

        public User FindingUser(string Username, string password) 
        {
            User CurrentUser = new User();
        //    UserLoginInformation();
        //    //UserInfoList.Any(CurrentUser => CurrentUser.Name == Username);
        //    CurrentUser = UserInfoList.Select(CurrentUser => CurrentUser.Name == Username && CurrentUser.Password == password ;
        //    if (UserInfoList.Select(CurrentUser => CurrentUser.Name == Username && CurrentUser.Password == password))
        //    {
                return(CurrentUser);
        //    }
        }

        public Boolean IsvalidUser(string Username, string password)
        {
            List<User> UserInfoList = UserLoginInformation();
            UserLoginInformation();
            if (UserInfoList.Any(CurrentUser => CurrentUser.Name == Username && CurrentUser.Password == password))
            {
                return (true);
            }
            else
            {
                return (false);
            };

        }

    }
}