using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

/// <summary>
/// Summary description for FormController
/// </summary>

public class FormSurfaceController : SurfaceController
{
    [HttpPost]
    public ActionResult SaveForm(FormModel model)
    {    
 
        if (!ModelState.IsValid)
        {
  
            return CurrentUmbracoPage();
        }

       ApplicationContext.DatabaseContext.Database.Save(new Movie());
        ViewBag.Result = "User Info Saved";
        
        return RedirectToCurrentUmbracoPage();

    }
}
