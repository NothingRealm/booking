using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Booking.Controllers
{
//fadfas
     [Route("www")]
     [ApiController]
     public class RedirectionController : ControllerBase
     {
        [HttpGet("{domain}/{topDomain}")]
        public void Redirection(string domain, string topDomain)
        {
            var redirectUrl = "https://www." + domain + "." + topDomain;
            Response.Redirect(redirectUrl);
        }

    }
}
