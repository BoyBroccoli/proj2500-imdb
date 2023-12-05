using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IMDB.Models;

[PrimaryKey("TitleId", "Ordering")]
[Table("Title_Aliases")]
public partial class TitleAlias
{
    [Key]
    [Column("titleId")]
    [StringLength(10)]
    [Unicode(false)]
    public string TitleId { get; set; } = null!;

    [Key]
    [Column("ordering")]
    public int Ordering { get; set; }

    [Column("title")]
    [StringLength(255)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column("region")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Region { get; set; }

    [Column("language")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Language { get; set; }

    [Column("isOriginalTitle")]
    public bool? IsOriginalTitle { get; set; }

    [ForeignKey("TitleId")]
    [InverseProperty("TitleAliases")]
    public virtual Title TitleNavigation { get; set; } = null!;
}
