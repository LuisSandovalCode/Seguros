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
    [RoutePrefix("api/v1/Customer")]
    public class CustomerController : ApiController
    {
        BusinessCustomer BusinessCustomer;
        public CustomerController()
        {
            BusinessCustomer = new BusinessCustomer();
        }

        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Create()
        {
            try
            {
                var RequestBody = Request.Content.ReadAsStringAsync().Result;

                var customer = RequestBody.DeserealizeJson<Customer>();

                return Ok(BusinessCustomer.Create(customer));
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
                var RequestBody = Request.Content.ReadAsStringAsync().Result;

                var customer = RequestBody.DeserealizeJson<Customer>();

                return Ok(BusinessCustomer.Update(customer));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [Route("AddPolicy")]
        [HttpPost]
        public IHttpActionResult AddPolicy()
        {
            try
            {
                var RequestBody = Request.Content.ReadAsStringAsync().Result;

                var customerPolicy = RequestBody.DeserealizeJson<CustomerPolicy>();

                return Ok(BusinessCustomer.AddPolicy(customerPolicy));
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
                var RequestBody = Request.Content.ReadAsStringAsync().Result;

                var customer = RequestBody.DeserealizeJson<Customer>();

                return Ok(BusinessCustomer.Delete(customer));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [Route("CustomerList")]
        [HttpPost]
        public IHttpActionResult GetCustomers()
        {
            try
            {
                var RequestBody = Request.Content.ReadAsStringAsync().Result;

                var customer = RequestBody.DeserealizeJson<Customer>();

                return Ok(BusinessCustomer.GetEntities(customer));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

    }
}
