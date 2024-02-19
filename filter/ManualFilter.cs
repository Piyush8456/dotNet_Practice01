using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters01.filter
{
    public class ManualFilter :FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("this is OnActionExecuted");

         }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("This is OnActionExecuting");
        }
    }
}