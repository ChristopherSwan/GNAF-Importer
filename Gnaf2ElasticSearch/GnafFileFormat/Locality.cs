using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("LOCALITY")]
public class Locality
{
    [Column("locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "locality pid is required")]
    [Display(Name = "locality pid")]
    public string locality_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("locality_name", TypeName = "varchar")]
    [MaxLength(100)]
    [Required(ErrorMessage = "locality name is required")]
    [Display(Name = "locality name")]
    public string locality_name { get; set; } // varchar(100), not null
    [Column("primary_postcode", TypeName = "varchar")]
    [MaxLength(4)]
    [Display(Name = "primary postcode")]
    public string primary_postcode { get; set; } // varchar(4), null
    [Column("locality_class_code", TypeName = "char")]
    [MaxLength(1)]
    [Required(ErrorMessage = "locality class code is required")]
    [Display(Name = "locality class code")]
    public string locality_class_code { get; set; } // char(1), not null
    [Column("state_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "state pid is required")]
    [Display(Name = "state pid")]
    public string state_pid { get; set; } // varchar(15), not null
    [Column("gnaf_locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "gnaf locality pid")]
    public string gnaf_locality_pid { get; set; } // varchar(15), null
    [Column("gnaf_reliability_code", TypeName = "numeric")]
    [Required(ErrorMessage = "gnaf reliability code is required")]
    [Display(Name = "gnaf reliability code")]
    public decimal gnaf_reliability_code { get; set; } // numeric(1,0), not null
}
