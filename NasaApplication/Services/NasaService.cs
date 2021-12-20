using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Apod;
using NasaApplication.Models;

namespace NasaApplication.Services
{
    public class  NasaService
    {


        public async Task<ResponseNasa> getApod()
        {
            string key = "pvzWKVp0Tnwp5Y06eLHeLESjB04PxvYEBZKxGcL4";
          
            var client= new ApodClient(key);
            ResponseNasa responseNasa;
            Console.WriteLine("ciaooooo");



            DateTime datetime  = DateTime.Now;
            var response = await client.FetchApodAsync(datetime);

            if (response.StatusCode != ApodStatusCode.OK)
            {
                Console.WriteLine(response.Error.ErrorCode);
                Console.WriteLine(response.Error.ErrorMessage);
                responseNasa = new ResponseNasa(-1);
            }
            else
            {
                ApodContent apod = response.Content;
                Console.WriteLine(apod.Title);
                Console.WriteLine(apod.ContentUrl);
                Console.WriteLine(apod.Explanation);
                responseNasa = new ResponseNasa(apod.Title, apod.ContentUrlHD, 1);
            }
            return responseNasa;
        }
       
    }
}
