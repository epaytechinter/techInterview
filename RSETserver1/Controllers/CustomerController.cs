using RSETserver1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace RSETserver1.Controllers
{
    public class CustomerController : Controller
    {
        public string Get()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<object> Categores = new List<object>();
            var customers = (List<Customer>)TempData["customres"];
            Categores.AddRange(customers);
            return serializer.Serialize(Categores);
        }

        
        public HttpResponseMessage Post(List<Customer> customers)
        {
            if (ModelState.IsValid)
            {
               TempData["customres"]= CustomersMange.AddCustomer((List<Customer>)TempData["customres"], customers);

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        public bool CheckUserId(int id)
        {
            var savedCustomers =(List<Customer>)TempData["customres"];
            return savedCustomers.Where(q=>q.id==id).Any();
        }

    }
}