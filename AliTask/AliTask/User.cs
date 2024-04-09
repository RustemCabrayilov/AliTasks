using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliTask
{
    internal class User
    {

        //User class - UserName,Password; hansisa biri private olacaq
        //CheckPassword - sifrenin uzunlugu min8, icnde uppercase ve digit(reqem) olmalidir(method)
        //Constructorda username ve password istenilir ve uygun deyilse set edilmeyecek.
        //(Encapsulation) SetPassword metodu - eger sifre uygundursa password field-ne value set edir, deyilse xeta mesaji verir
        private string _userName { get; set; }
        private string _password { get; set; }
        public string Password { set {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            } }

        public User(string UserName, string Password)
        {
            this._userName = UserName;
            this.Password = Password;
            Console.WriteLine("Succesfully registered");
        }
        public bool CheckPassword(string Password)
        {
            if (Password == null || Password.Length < 8)
            {
                return false;
            }
            bool hasUpper = false;
            bool hasDigit = false;
            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
            if (!hasUpper || !hasDigit)
            {
                return false;
            }
            return true;
        }
    }
}
