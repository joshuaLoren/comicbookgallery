using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{

    public class ComicBookController : Controller         //this needs to be public!! Or, MVC won't find it
    {
    
        /**
         *  @ return ActionResult
         */
        public ActionResult Detail()                             //this is an action method
        {
           
   


            if(DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                //Redirect method accepts a string for the target URL
                //passing / to the constructor sends us to the root of the website
                return Redirect("/");
                  
            }

            //content message of the Controller "type" or "class"
            return Content("Some message");
 
        }


        
    }
}