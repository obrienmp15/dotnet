using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using PizzaStoreApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace PizzaStoreApi.Client.Controllers
{
  public class AccountController : ApiController
  {
    private static UserStore<IdentityUser> credentials = new UserStore<IdentityUser>();
    
    public HttpResponseMessage Post([FromBody] UserAccount account)
    {

      var user = new IdentityUser() { UserName = account.UserName};
      var manager = new UserManager<IdentityUser>(credentials);
      var result = manager.Create(user, account.Password);

      if (result.Succeeded)
      {
        return Request.CreateResponse(HttpStatusCode.OK);
      }

      return Request.CreateResponse(HttpStatusCode.BadRequest);

    }
    public HttpResponseMessage Delete(string user)
    {
      var manager = new UserManager<IdentityUser>(credentials);
      var u = manager.FindByName(user);
      var result = manager.Delete(u);

      if (result.Succeeded)
      {
        return Request.CreateResponse(HttpStatusCode.OK);
      }

      return Request.CreateResponse(HttpStatusCode.BadRequest);

    }

    [HttpGet]
    public HttpResponseMessage Login([FromUri] UserAccount account)
    {
      var manager = new UserManager<IdentityUser>(credentials);
      var u = manager.FindByName(account.UserName);
      
      if (u == null)
      {
        return Request.CreateResponse(HttpStatusCode.BadRequest);
      }
      var auth = HttpContext.Current.GetOwinContext().Authentication;
      var id = manager.CreateIdentity(u, DefaultAuthenticationTypes.ApplicationCookie);

      auth.SignIn(new AuthenticationProperties() { IsPersistent = true}, id);
      
      return Request.CreateResponse(HttpStatusCode.OK);
      
    }

    [HttpGet]
    [Agent007]
    public HttpResponseMessage Logout()
    {
      var auth = HttpContext.Current.GetOwinContext().Authentication;

      auth.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

      return Request.CreateResponse(HttpStatusCode.OK);

    }

  }
}
