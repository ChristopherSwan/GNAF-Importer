using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MB_2011")]
public class Mb2011
{
    [Column("mb_2011_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "mb 2011 pid is required")]
    [Display(Name = "mb 2011 pid")]
    public string mb_2011_pid { get; set; } // varchar(15), not null
    [Column("date_created", TypeName = "datetime")]
    [Required(ErrorMessage = "date created is required")]
    [Display(Name = "date created")]
    public DateTime date_created { get; set; } // datetime, not null
    [Column("date_retired", TypeName = "datetime")]
    [Display(Name = "date retired")]
    public DateTime? date_retired { get; set; } // datetime, null
    [Column("mb_2011_code", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "mb 2011 code is required")]
    [Display(Name = "mb 2011 code")]
    public string mb_2011_code { get; set; } // varchar(15), not null
}
