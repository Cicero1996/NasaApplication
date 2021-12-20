using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NasaApplication.Models;
using NasaApplication.Services;

namespace NasaApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NasaController : ControllerBase
    {
        private NasaService nasaService;

        public NasaController() {
            nasaService = new NasaService();
        }
      
        [HttpGet]
        public async Task<string> Get()
        {
            Task<ResponseNasa> response = nasaService.getApod();

            ResponseNasa r = await response;

            if (r.Codeerror == - 1)
            {
                return "Error request";
    
            }

            Response.Redirect(r.ContentUrl1);
            return response.ToString();
        }

   
    }
}



   
        
    

