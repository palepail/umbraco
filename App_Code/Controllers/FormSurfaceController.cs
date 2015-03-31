using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Persistence;


/// <summary>
/// FormController
/// </summary>

public class FormSurfaceController : SurfaceController
{

    //in Java the DAO would be injected, I'm not sure how MVC handles that.
    FormDAO formDAO = new FormDAO();

    [HttpPost]
    public ActionResult SaveForm(FormModel model)
    {    
 
        if (!ModelState.IsValid)
            {
            return CurrentUmbracoPage();
            }

        //this would pass though a manager first if there were any calculated values or any logic
        formDAO.persistData(model);
       
        return RedirectToCurrentUmbracoPage();

    }

   

}
