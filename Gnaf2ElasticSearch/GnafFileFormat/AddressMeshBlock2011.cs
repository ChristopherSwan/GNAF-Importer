using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ADDRESS_MESH_BLOCK_2011")]
public class AddressMeshBlock2011
{
    [Column("address_mesh_block_2011_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "address mesh block 2011 pid is required")]
    [Display(Name = "address mesh block 2011 pid")]
    public string address_mesh_block_2011_pid { get; set; } // varchar(15), not null
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
    [Column("mb_match_code", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "mb match code is required")]
    [Display(Name = "mb match code")]
    public string mb_match_code { get; set; } // varchar(15), not null
    [Column("mb_2011_pid", TypeName = "varchar")]
    [MaxLength(15)]
    [Required(ErrorMessage = "mb 2011 pid is required")]
    [Display(Name = "mb 2011 pid")]
    public string mb_2011_pid { get; set; } // varchar(15), not null
}
