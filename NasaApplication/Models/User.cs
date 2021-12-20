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


        public bool VerifiedUser(User u)
        {
            if (this.Mail == u.Mail && this.passwordSHA == u.PasswordSha)
                return true;
            else
                return false;

        }


    }
}
