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
         *  
         */
        public ActionResult Detail()                             //this is an action method
        {
            //view method of the Controller class we are inheriting from
            return View();
 
        }


        
    }
}