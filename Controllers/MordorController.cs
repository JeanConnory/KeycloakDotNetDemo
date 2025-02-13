﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeycloakDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MordorController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "CreateRing")]
        public ActionResult CreateRing()
        {
            return Ok("Ash nazg durbatulûk, ash nazg gimbatul, ash nazg thrakatulûk, agh burzum-ishi krimpatul");
        }

        [HttpDelete]
        [Authorize(Roles = "DestroyRing")]
        public ActionResult DestroyRing()
        {
            return Ok("Detroy Ring");
        }
    }
}
