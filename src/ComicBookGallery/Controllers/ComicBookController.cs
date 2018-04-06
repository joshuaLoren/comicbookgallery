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
            //the View() method is used to return a ViewResult object from the action method of the controller
            return View();

            //note: inside the View folder there will be a reference to the Controller that
            //is used to access that view. In this case, our View Folder has a Folder Named ComicBook
            //and a Razor file (.cshtml) name Detail (the name of our action method

 
        }


        
    }
}