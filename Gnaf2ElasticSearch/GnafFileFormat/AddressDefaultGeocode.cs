using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("ADDRESS_DEFAULT_GEOCODE")]
public class AddressDefaultGeocode
{
    [Column("address_default_geocode_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address default geocode pid is required")]
    [Display(Name = "address default geocode pid")]
    public string address_default_geocode_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("address_detail_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address detail pid is required")]
    [Display(Name = "address detail pid")]
    public string address_detail_pid { get; set; } // varchar(15), not null
    [Column("geocode_type_code", TypeName = "varchar")]
    [MaxLength(4)]
    [Required(ErrorMessage = "geocode type code is required")]
    [Display(Name = "geocode type code")]
    public string geocode_type_code { get; set; } // varchar(4), not null
    [Column("longitude", TypeName = "numeric")]
    [Display(Name = "longitude")]
    public decimal? longitude { get; set; } // numeric(11,8), null
    [Column("latitude", TypeName = "numeric")]
    [Display(Name = "latitude")]
    public decimal? latitude { get; set; } // numeric(10,8), null
}
