using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountAPI.Core.Interfaces.Handlers;
using AccountAPI.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountAPI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountNotificationHandler accountNoti;

        public AccountController(IAccountNotificationHandler accountNoti)
        {
            this.accountNoti = accountNoti;
        }

        [Route("process-noti")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AccountNotiRequest request)
        {
            var result = await accountNoti.ProcessNotificationAsync(request.Account.AccountCode);

            return Ok(result);
        }

        [Route("test")]
        [HttpGet]
        public IActionResult Ping() => Ok("Pong");
    }
}