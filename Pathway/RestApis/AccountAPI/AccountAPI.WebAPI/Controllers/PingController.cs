using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountAPI.WebAPI.Controllers
{
    [ApiController]
    [Route("Ping")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping() => Ok("Pong");
    }
}