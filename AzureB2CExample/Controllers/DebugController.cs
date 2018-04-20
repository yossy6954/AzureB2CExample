using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AzureB2CExample.Controllers {
    [Route("api/[controller]")]
    public class DebugController : Controller {
        // GET api/Debug/me
        [Authorize]
        [HttpGet("me")]
        public Dictionary<string, string> Me() {
            return (User.Identity as ClaimsIdentity).Claims
                .ToDictionary(c => c.Type, c => c.Value);
        }
    }
}
