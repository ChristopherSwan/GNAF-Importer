using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("STREET_LOCALITY")]
public class StreetLocality
{
    [Column("street_locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "street locality pid is required")]
    [Display(Name = "street locality pid")]
    public string street_locality_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("street_class_code", TypeName = "char")]
    [MaxLength(1)]
    [Required(ErrorMessage = "street class code is required")]
    [Display(Name = "street class code")]
    public string street_class_code { get; set; } // char(1), not null
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
    [Column("locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "locality pid is required")]
    [Display(Name = "locality pid")]
    public string locality_pid { get; set; } // varchar(15), not null
    [Column("gnaf_street_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "gnaf street pid")]
    public string gnaf_street_pid { get; set; } // varchar(15), null
    [Column("gnaf_street_confidence", TypeName = "numeric")]
    [Display(Name = "gnaf street confidence")]
    public decimal? gnaf_street_confidence { get; set; } // numeric(1,0), null
    [Column("gnaf_reliability_code", TypeName = "numeric")]
    [Required(ErrorMessage = "gnaf reliability code is required")]
    [Display(Name = "gnaf reliability code")]
    public decimal gnaf_reliability_code { get; set; } // numeric(1,0), not null
}
