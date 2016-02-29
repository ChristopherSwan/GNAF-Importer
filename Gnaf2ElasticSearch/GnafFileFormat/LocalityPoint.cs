using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("LOCALITY_POINT")]
public class LocalityPoint
{
    [Column("locality_point_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "locality point pid is required")]
    [Display(Name = "locality point pid")]
    public string locality_point_pid { get; set; } // varchar(15), not null
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
    [Column("planimetric_accuracy", TypeName = "numeric")]
    [Display(Name = "planimetric accuracy")]
    public decimal? planimetric_accuracy { get; set; } // numeric(12,0), null
    [Column("longitude", TypeName = "numeric")]
    [Display(Name = "longitude")]
    public decimal? longitude { get; set; } // numeric(11,8), null
    [Column("latitude", TypeName = "numeric")]
    [Display(Name = "latitude")]
    public decimal? latitude { get; set; } // numeric(10,8), null
}
