using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLibrary
{
    public class Password
    {
        string myPassword;
        public Password(string password)
        {
            myPassword = password;
        }
        public bool CheckPassword()
        {
            Regex digit = new Regex(@"\d");
            if (myPassword.Length < 6)
                return false;
            else
                return digit.IsMatch(myPassword);
        }
    }
}
