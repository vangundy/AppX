using AppX.Shared;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppX.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicController : ControllerBase
    {
        [HttpGet]
        public DateMessage Get()
        {
            return new DateMessage{ TheDate = DateTime.Now };
        }
    }
}
