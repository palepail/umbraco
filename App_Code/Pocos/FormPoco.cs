using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Form Entity
/// </summary>

using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

    [TableName("Forms")]
    [PrimaryKey("ID", autoIncrement = true)]
    [ExplicitColumns]
public class FormPoco
{

        [Column("ID")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int id { get; set; }

        [Column("FIRST_NAME")]
        public String firstName { get; set; }

        [Column("LAST_NAME")]
        public String lastName { get; set; }

        [Column("EMAIL")]
        public String email { get; set; }
    
}
