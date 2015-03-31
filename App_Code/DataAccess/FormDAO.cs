using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Form Data Access Object
/// </summary>
public class FormDAO
{
        
        public void persistData(FormModel model){
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
