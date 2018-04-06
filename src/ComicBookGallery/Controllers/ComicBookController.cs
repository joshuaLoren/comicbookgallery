using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller         //this needs to be public!! Or, MVC won't find it
    {

        public string Detail()                             //this is an action method
        {
            return "hello from comic books controller";
        }
        
    }
}