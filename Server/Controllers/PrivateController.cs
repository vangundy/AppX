using AppX.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace AppX.Server.Controllers
{
    [Authorize]
    [RequiredScope("API.Access")]
    [Route("api/[controller]")]
    [ApiController]
    public class PrivateController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new ResponseMessage
            {
                Message = $"{User.Identity.Name} has accessed private API."
            });
        }
    }
}
