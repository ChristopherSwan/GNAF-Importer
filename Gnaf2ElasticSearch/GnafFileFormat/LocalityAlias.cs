using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("LOCALITY_ALIAS")]
public class LocalityAlias
{
    [Column("locality_alias_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "locality alias pid is required")]
    [Display(Name = "locality alias pid")]
    public string locality_alias_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "locality pid is required")]
    [Display(Name = "locality pid")]
    public string locality_pid { get; set; } // varchar(15), not null
    [Column("name", TypeName = "varchar")]
    [MaxLength(100)]
    [Required(ErrorMessage = "name is required")]
    [Display(Name = "name")]
    public string name { get; set; } // varchar(100), not null
    [Column("postcode", TypeName = "varchar")]
    [MaxLength(4)]
    [Display(Name = "postcode")]
    public string postcode { get; set; } // varchar(4), null
    [Column("alias_type_code", TypeName = "varchar")]
    [MaxLength(10)]
    [Required(ErrorMessage = "alias type code is required")]
    [Display(Name = "alias type code")]
    public string alias_type_code { get; set; } // varchar(10), not null
    [Column("state_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "state pid is required")]
    [Display(Name = "state pid")]
    public string state_pid { get; set; } // varchar(15), not null
}
