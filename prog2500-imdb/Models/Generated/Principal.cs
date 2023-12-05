using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IMDB.Models;

[PrimaryKey("TitleId", "Ordering")]
public partial class Principal
{
    [Key]
    [Column("titleID")]
    [StringLength(10)]
    [Unicode(false)]
    public string TitleId { get; set; } = null!;

    [Key]
    [Column("ordering")]
    public int Ordering { get; set; }

    [Column("nameID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NameId { get; set; }

    [Column("job_category")]
    [StringLength(30)]
    [Unicode(false)]
    public string? JobCategory { get; set; }

    [Column("job")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Column("characters")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Characters { get; set; }

    [ForeignKey("NameId")]
    [InverseProperty("Principals")]
    public virtual Name? Name { get; set; }
}
