using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("PRIMARY_SECONDARY")]
public class PrimarySecondary
{
    [Column("primary_secondary_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "primary secondary pid is required")]
    [Display(Name = "primary secondary pid")]
    public string primary_secondary_pid { get; set; } // varchar(15), not null
    [Column("primary_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "primary pid is required")]
    [Display(Name = "primary pid")]
    public string primary_pid { get; set; } // varchar(15), not null
    [Column("secondary_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "secondary pid is required")]
    [Display(Name = "secondary pid")]
    public string secondary_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("ps_join_type_code", TypeName = "numeric")]
    [Required(ErrorMessage = "ps join type code is required")]
    [Display(Name = "ps join type code")]
    public decimal ps_join_type_code { get; set; } // numeric(2,0), not null
    [Column("ps_join_comment", TypeName = "varchar")]
    [MaxLength(500)]
    [Display(Name = "ps join comment")]
    public string ps_join_comment { get; set; } // varchar(500), null
}
