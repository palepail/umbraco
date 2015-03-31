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
    [HttpPost]
    public ActionResult SaveForm(FormModel model)
    {    
 
        if (!ModelState.IsValid)
            {
            return CurrentUmbracoPage();
            }


        persistData(model);
       
        return RedirectToCurrentUmbracoPage();

    }

    //DAO would be in a seperate file normally
    private void persistData(FormModel model){
        var db = ApplicationContext.DatabaseContext.Database;
        if (!db.TableExist("Forms"))
            {
                db.CreateTable<FormPoco>(false);
            }

     
     
        FormPoco poco = new FormPoco(); 
      

        poco.email = model.Email;
        poco.firstName = model.FirstName;
        poco.lastName = model.LastName;

        db.Insert(poco);
    }
}
