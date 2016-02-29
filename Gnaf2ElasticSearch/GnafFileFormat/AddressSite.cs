using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ADDRESS_SITE")]
public class AddressSite
{
    [Column("address_site_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address site pid is required")]
    [Display(Name = "address site pid")]
    public string address_site_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("address_type", TypeName = "varchar")]
    [MaxLength(8)]
    [Display(Name = "address type")]
    public string address_type { get; set; } // varchar(8), null
    [Column("address_site_name", TypeName = "varchar")]
    [MaxLength(45)]
    [Display(Name = "address site name")]
    public string address_site_name { get; set; } // varchar(45), null
}
