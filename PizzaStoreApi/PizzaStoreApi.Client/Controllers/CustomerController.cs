using PizzaStoreApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreApi.Client.Controllers
{
  public class CustomerController : ApiController
  {

    public HttpResponseMessage Get(int id)
    {
      return Request.CreateResponse<Customer>(HttpStatusCode.OK, new Customer());
    }

    public HttpResponseMessage Get()
    {
      return Request.CreateResponse<List<string>>(HttpStatusCode.OK, new List<string> { "a", "b", "c" });
    }
    // Never do this with POST
    //public int Post(int id)
    //{
    //  return id;
    //}

    public string Post([FromBody]Name name)
    {
      return name.ToString();
    }

    public string Put([FromBody]Name name)
    {
      return name.ToString();
    }

    public string Delete(int id)
    {
      return "done";
    }

  }
}
