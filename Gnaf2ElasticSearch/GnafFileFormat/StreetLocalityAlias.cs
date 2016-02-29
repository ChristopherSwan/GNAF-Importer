using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("STREET_LOCALITY_ALIAS")]
public class StreetLocalityAlias
{
    [Column("street_locality_alias_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "street locality alias pid is required")]
    [Display(Name = "street locality alias pid")]
    public string street_locality_alias_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("street_locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "street locality pid is required")]
    [Display(Name = "street locality pid")]
    public string street_locality_pid { get; set; } // varchar(15), not null
    [Column("street_name", TypeName = "varchar")]
    [MaxLength(100)]
    [Required(ErrorMessage = "street name is required")]
    [Display(Name = "street name")]
    public string street_name { get; set; } // varchar(100), not null
    [Column("street_type_code", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "street type code")]
    public string street_type_code { get; set; } // varchar(15), null
    [Column("street_suffix_code", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "street suffix code")]
    public string street_suffix_code { get; set; } // varchar(15), null
    [Column("alias_type_code", TypeName = "varchar")]
    [MaxLength(10)]
    [Required(ErrorMessage = "alias type code is required")]
    [Display(Name = "alias type code")]
    public string alias_type_code { get; set; } // varchar(10), not null
}
