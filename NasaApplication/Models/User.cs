using System;
namespace NasaApplication.Models
{
    public class User
    {

        private string mail;
        private string passwordSHA;
        private string name;

        public User(string mail, string passwordSHA)
        {
            this.mail = mail;
            this.passwordSHA = passwordSHA;
        }


        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public string PasswordSha
        {
            get => passwordSHA;
            set => passwordSHA = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }


        public bool VerifiedUser(string mail, string password)
        {
            if (this.Mail == mail && this.passwordSHA == password)
                return true;
            else
                return false;

        }


    }
}
