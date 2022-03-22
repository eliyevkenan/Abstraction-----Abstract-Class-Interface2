using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp49
{
    internal class User:IAccount
    {
        public User(string email,string password)
        {
            this.Email =email;
            this.Password = password;

        }
        public string Email;
        public string _Password;
        public string FullName;
        
        public string Password
        {
            get=>this._Password;
            set
            {
                if (PasswordNew(value))
                    this._Password = value; 
            }
        }
         public bool PasswordNew(string password)
        {
            bool isDigit=false;
            bool isUpper=false;
            bool isLower=false;
            bool result=false;
            if (password.Length>7)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]))
                    {
                        isUpper = true;
                    }
                    else if (Char.IsLower(password[i]))
                    {
                         isLower = true;    
                    }
                    else if (char.IsDigit(password[i]))
                    {
                        isDigit=false;
                    }
                    if (isUpper && isLower && isDigit)
                    {
                        result = true;
                        break;
                    }
                }

            }
        }
            

    }
}
