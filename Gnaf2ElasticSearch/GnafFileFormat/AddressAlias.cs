using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ADDRESS_ALIAS")]
public class AddressAlias
{
    [Column("address_alias_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address alias pid is required")]
    [Display(Name = "address alias pid")]
    public string address_alias_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("principal_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "principal pid is required")]
    [Display(Name = "principal pid")]
    public string principal_pid { get; set; } // varchar(15), not null
    [Column("alias_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "alias pid is required")]
    [Display(Name = "alias pid")]
    public string alias_pid { get; set; } // varchar(15), not null
    [Column("alias_type_code", TypeName = "varchar")]
    [MaxLength(10)]
    [Required(ErrorMessage = "alias type code is required")]
    [Display(Name = "alias type code")]
    public string alias_type_code { get; set; } // varchar(10), not null
    [Column("alias_comment", TypeName = "varchar")]
    [MaxLength(200)]
    [Display(Name = "alias comment")]
    public string alias_comment { get; set; } // varchar(200), null
}
