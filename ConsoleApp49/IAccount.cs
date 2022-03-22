using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp49
{
    internal interface IAccount
    {
        public void PasswordChecker(string passowrd);
        public void ShowInfo()
        {
            Console.WriteLine($"FullName:{FullName}+ +Email:{Email}");
        }
    }
}
