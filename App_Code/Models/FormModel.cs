using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// FormDTO
/// </summary>

public class FormModel
{
    [Required]
    public String FirstName { get; set; }

    [Required]
    public String LastName { get; set; }

    [Required]
    [EmailAddress]
    public String Email { get; set; }
}
