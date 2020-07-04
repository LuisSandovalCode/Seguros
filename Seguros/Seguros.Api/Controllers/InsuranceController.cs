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
    [RoutePrefix("api/v1/Insurance")]
    public class InsuranceController : ApiController
    {
        BusinessInsurancePolicy insurancePolicy;

        public InsuranceController()
        {
            insurancePolicy = new BusinessInsurancePolicy();
        }

        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Create()
        {
            try
            {
                string RequestBody = Request.Content.ReadAsStringAsync().Result;

                var insurance = RequestBody.DeserealizeJson<InsurancePolicy>();

                return Ok(insurancePolicy.Create(insurance));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [Route("Update")]
        [HttpPost]
        public IHttpActionResult Update()
        {
            try
            {
                string RequestBody = Request.Content.ReadAsStringAsync().Result;

                var insurance = RequestBody.DeserealizeJson<InsurancePolicy>();

                return Ok(insurancePolicy.Update(insurance));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [Route("Delete")]
        [HttpPost]
        public IHttpActionResult Delete()
        {
            try
            {
                string RequestBody = Request.Content.ReadAsStringAsync().Result;

                var insurance = RequestBody.DeserealizeJson<InsurancePolicy>();

                return Ok(insurancePolicy.Delete(insurance));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [Route("InsurancesList")]
        [HttpPost]
        public IHttpActionResult GetInsurances()
        {
            try
            {
                string RequestBody = Request.Content.ReadAsStringAsync().Result;

                var insurance = RequestBody.DeserealizeJson<InsurancePolicy>();

                return Ok(insurancePolicy.GetEntities(insurance));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
    }
}
