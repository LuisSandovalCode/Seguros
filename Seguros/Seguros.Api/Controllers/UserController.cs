using Seguros.Business;
using Seguros.Business.Utils;
using Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Seguros.Api.Controllers
{
    [RoutePrefix("api/v1/User")]
    public class UserController : ApiController
    {
        BusinnessUser BusinnessUser;
        public UserController()
        {
            BusinnessUser = new BusinnessUser();
        }

        [Route("Auth")]
        [HttpPost]
        public IHttpActionResult AuthUser()
        {
			try
			{
                var RequestBody = Request.Content.ReadAsStringAsync().Result;

                var user = RequestBody.DeserealizeJson<User>();

                return Ok(BusinnessUser.AutenticateUser(user));
			}
			catch (Exception ex)
			{
                return InternalServerError();
			}
        }
    }
}
