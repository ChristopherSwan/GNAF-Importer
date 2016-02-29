using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("LOCALITY_NEIGHBOUR")]
public class LocalityNeighbour
{
    [Column("locality_neighbour_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "locality neighbour pid is required")]
    [Display(Name = "locality neighbour pid")]
    public string locality_neighbour_pid { get; set; } // varchar(15), not null
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
    [Column("neighbour_locality_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "neighbour locality pid is required")]
    [Display(Name = "neighbour locality pid")]
    public string neighbour_locality_pid { get; set; } // varchar(15), not null
}
