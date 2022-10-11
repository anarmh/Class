using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account
    {
        public string username;
        public string password;
        public Account(string username,string password)
        {if(username== "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("girish ugurludur");
            }
            else
            {
                Console.WriteLine("email ve ya password sehvdir");
            }
        }
        
    }
}
