using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ADDRESS_DETAIL")]
public class AddressDetail
{
    [Column("address_detail_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address detail pid is required")]
    [Display(Name = "address detail pid")]
    public string address_detail_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_last_modified", TypeName = "datetime")]
    [Display(Name = "date last modified")]
    public DateTime? date_last_modified { get; set; } // datetime, null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("building_name", TypeName = "varchar")]
    [MaxLength(45)]
    [Display(Name = "building name")]
    public string building_name { get; set; } // varchar(45), null
    [Column("lot_number_prefix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "lot number prefix")]
    public string lot_number_prefix { get; set; } // varchar(2), null
    [Column("lot_number", TypeName = "varchar")]
    [MaxLength(5)]
    [Display(Name = "lot number")]
    public string lot_number { get; set; } // varchar(5), null
    [Column("lot_number_suffix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "lot number suffix")]
    public string lot_number_suffix { get; set; } // varchar(2), null
    [Column("flat_type_code", TypeName = "varchar")]
    [MaxLength(7)]
    [Display(Name = "flat type code")]
    public string flat_type_code { get; set; } // varchar(7), null
    [Column("flat_number_prefix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "flat number prefix")]
    public string flat_number_prefix { get; set; } // varchar(2), null
    [Column("flat_number", TypeName = "numeric")]
    [Display(Name = "flat number")]
    public decimal? flat_number { get; set; } // numeric(5,0), null
    [Column("flat_number_suffix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "flat number suffix")]
    public string flat_number_suffix { get; set; } // varchar(2), null
    [Column("level_type_code", TypeName = "varchar")]
    [MaxLength(4)]
    [Display(Name = "level type code")]
    public string level_type_code { get; set; } // varchar(4), null
    [Column("level_number_prefix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "level number prefix")]
    public string level_number_prefix { get; set; } // varchar(2), null
    [Column("level_number", TypeName = "numeric")]
    [Display(Name = "level number")]
    public decimal? level_number { get; set; } // numeric(3,0), null
    [Column("level_number_suffix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "level number suffix")]
    public string level_number_suffix { get; set; } // varchar(2), null
    [Column("number_first_prefix", TypeName = "varchar")]
    [MaxLength(3)]
    [Display(Name = "number first prefix")]
    public string number_first_prefix { get; set; } // varchar(3), null
    [Column("number_first", TypeName = "numeric")]
    [Display(Name = "number first")]
    public decimal? number_first { get; set; } // numeric(6,0), null
    [Column("number_first_suffix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "number first suffix")]
    public string number_first_suffix { get; set; } // varchar(2), null
    [Column("number_last_prefix", TypeName = "varchar")]
    [MaxLength(3)]
    [Display(Name = "number last prefix")]
    public string number_last_prefix { get; set; } // varchar(3), null
    [Column("number_last", TypeName = "numeric")]
    [Display(Name = "number last")]
    public decimal? number_last { get; set; } // numeric(6,0), null
    [Column("number_last_suffix", TypeName = "varchar")]
    [MaxLength(2)]
    [Display(Name = "number last suffix")]
    public string number_last_suffix { get; set; } // varchar(2), null
    [Column("street_locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "street locality pid")]
    public string street_locality_pid { get; set; } // varchar(15), null
    [Column("location_description", TypeName = "varchar")]
    [MaxLength(45)]
    [Display(Name = "location description")]
    public string location_description { get; set; } // varchar(45), null
    [Column("locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "locality pid is required")]
    [Display(Name = "locality pid")]
    public string locality_pid { get; set; } // varchar(15), not null
    [Column("alias_principal", TypeName = "char")]
    [MaxLength(1)]
    [Display(Name = "alias principal")]
    public string alias_principal { get; set; } // char(1), null
    [Column("postcode", TypeName = "varchar")]
    [MaxLength(4)]
    [Display(Name = "postcode")]
    public string postcode { get; set; } // varchar(4), null
    [Column("private_street", TypeName = "varchar")]
    [MaxLength(75)]
    [Display(Name = "private street")]
    public string private_street { get; set; } // varchar(75), null
    [Column("legal_parcel_id", TypeName = "varchar")]
    [MaxLength(20)]
    [Display(Name = "legal parcel id")]
    public string legal_parcel_id { get; set; } // varchar(20), null
    [Column("confidence", TypeName = "numeric")]
    [Display(Name = "confidence")]
    public decimal? confidence { get; set; } // numeric(1,0), null
    [Column("address_site_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address site pid is required")]
    [Display(Name = "address site pid")]
    public string address_site_pid { get; set; } // varchar(15), not null
    [Column("level_geocoded_code", TypeName = "numeric")]
    [Required(ErrorMessage = "level geocoded code is required")]
    [Display(Name = "level geocoded code")]
    public decimal level_geocoded_code { get; set; } // numeric(2,0), not null
    [Column("property_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "property pid")]
    public string property_pid { get; set; } // varchar(15), null
    [Column("gnaf_property_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Display(Name = "gnaf property pid")]
    public string gnaf_property_pid { get; set; } // varchar(15), null
    [Column("primary_secondary", TypeName = "varchar")]
    [MaxLength(1)]
    [Display(Name = "primary secondary")]
    public string primary_secondary { get; set; } // varchar(1), null
}
