﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;

namespace UserManagement
{
    public class UserManagement : DataManager.Worker, IUserManagement
    {
        public int GetUserRights()
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
