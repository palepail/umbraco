using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;


public class FormModel
{
    public FormModel(){
        
    }

    public int id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
