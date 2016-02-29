using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ADDRESS_SITE_GEOCODE")]
public class AddressSiteGeocode
{
    [Column("address_site_geocode_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address site geocode pid is required")]
    [Display(Name = "address site geocode pid")]
    public string address_site_geocode_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("address_site_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "address site pid")]
    public string address_site_pid { get; set; } // varchar(15), null
    [Column("geocode_site_name", TypeName = "varchar")]
    [MaxLength(46)]
    [Display(Name = "geocode site name")]
    public string geocode_site_name { get; set; } // varchar(46), null
    [Column("geocode_site_description", TypeName = "varchar")]
    [MaxLength(45)]
    [Display(Name = "geocode site description")]
    public string geocode_site_description { get; set; } // varchar(45), null
    [Column("geocode_type_code", TypeName = "varchar")]
    [MaxLength(4)]
    [Display(Name = "geocode type code")]
    public string geocode_type_code { get; set; } // varchar(4), null
    [Column("reliability_code", TypeName = "numeric")]
    [Required(ErrorMessage = "reliability code is required")]
    [Display(Name = "reliability code")]
    public decimal reliability_code { get; set; } // numeric(1,0), not null
    [Column("boundary_extent", TypeName = "numeric")]
    [Display(Name = "boundary extent")]
    public decimal? boundary_extent { get; set; } // numeric(7,0), null
    [Column("planimetric_accuracy", TypeName = "numeric")]
    [Display(Name = "planimetric accuracy")]
    public decimal? planimetric_accuracy { get; set; } // numeric(12,0), null
    [Column("elevation", TypeName = "numeric")]
    [Display(Name = "elevation")]
    public decimal? elevation { get; set; } // numeric(7,0), null
    [Column("longitude", TypeName = "numeric")]
    [Display(Name = "longitude")]
    public decimal? longitude { get; set; } // numeric(11,8), null
    [Column("latitude", TypeName = "numeric")]
    [Display(Name = "latitude")]
    public decimal? latitude { get; set; } // numeric(10,8), null
}
