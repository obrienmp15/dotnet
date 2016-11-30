﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMvc.Client
{
  public class ValidAction : ActionFilterAttribute
  {
    
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      var context = filterContext.RequestContext.HttpContext;

      if (context.Request.UserAgent.Contains("IE"))
      {
        context.Response.Redirect("~/ie/index");
      }

      //Log.Write();
    }
  }
}