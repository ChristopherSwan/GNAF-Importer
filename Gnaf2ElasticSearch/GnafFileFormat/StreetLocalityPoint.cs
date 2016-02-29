using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("STREET_LOCALITY_POINT")]
public class StreetLocalityPoint
{
    [Column("street_locality_point_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "street locality point pid is required")]
    [Display(Name = "street locality point pid")]
    public string street_locality_point_pid { get; set; } // varchar(15), not null
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
    [Column("boundary_extent", TypeName = "numeric")]
    [Display(Name = "boundary extent")]
    public decimal? boundary_extent { get; set; } // numeric(7,0), null
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
