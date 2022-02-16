using AppX.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppX.Server.Controllers
{
    [AllowAnonymous]
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
