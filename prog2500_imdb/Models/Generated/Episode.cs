using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace prog2500_imdb.Models;

public partial class Episode
{
    [Key]
    [Column("titleID")]
    [StringLength(10)]
    [Unicode(false)]
    public string TitleId { get; set; } = null!;

    [Column("parent_titleID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ParentTitleId { get; set; }

    [Column("seasonNumber")]
    public int? SeasonNumber { get; set; }

    [Column("episodeNumber")]
    public int? EpisodeNumber { get; set; }

    [ForeignKey("ParentTitleId")]
    [InverseProperty("EpisodeParentTitles")]
    public virtual Title? ParentTitle { get; set; }

    [ForeignKey("TitleId")]
    [InverseProperty("EpisodeTitle")]
    public virtual Title Title { get; set; } = null!;
}
