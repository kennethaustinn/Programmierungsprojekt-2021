using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterfaces
{

    public interface IDataManagerPatient
    {

    }

    public interface IDataManagerUser
    {

    }

    public interface IUserManagement
    {
        int ID { get; }

        string Username { get; }
        
        bool LogIn(string username, string password);

        bool LogOut();

        bool GetLoginStatus();

    }

    public interface IPatient
    {

    }

    public interface IOCRManager
    {

    }
}
