using System;
namespace NasaApplication.Models
{
    public class ResponseNasa 
    {

        private string Title;
        private string ContentUrl;
        private int codeError;


        public string Title1
        {
            get => Title;
            set => Title = value;
        }

        public string ContentUrl1
        {
            get => ContentUrl;
            set => ContentUrl = value;
        }

        public int Codeerror
        {
            get => codeError;
            set => codeError = value;
        }

        public ResponseNasa(string title, string contentUrl, int codeerror)
        {
            Title = title;
            ContentUrl = contentUrl;
            this.codeError = codeerror;
        }

        public ResponseNasa(int codeerror)
        {
            this.codeError = codeerror;
        }
    }
}


