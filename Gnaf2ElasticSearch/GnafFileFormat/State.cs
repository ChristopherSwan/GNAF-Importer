using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("STATE")]
public class State
{
    [Column("state_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "state pid is required")]
    [Display(Name = "state pid")]
    public string state_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("state_name", TypeName = "varchar")]
    [MaxLength(50)]
    [Required(ErrorMessage = "state name is required")]
    [Display(Name = "state name")]
    public string state_name { get; set; } // varchar(50), not null
    [Column("state_abbreviation", TypeName = "varchar")]
    [MaxLength(3)]
    [Required(ErrorMessage = "state abbreviation is required")]
    [Display(Name = "state abbreviation")]
    public string state_abbreviation { get; set; } // varchar(3), not null
}
