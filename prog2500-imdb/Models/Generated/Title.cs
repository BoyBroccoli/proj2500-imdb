using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IMDB.Models;

public partial class Title
{
    [Key]
    [Column("titleID")]
    [StringLength(10)]
    [Unicode(false)]
    public string TitleId { get; set; } = null!;

    [Column("titleType")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TitleType { get; set; }

    [Column("primaryTitle")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PrimaryTitle { get; set; }

    [Column("originalTitle")]
    [StringLength(255)]
    [Unicode(false)]
    public string? OriginalTitle { get; set; }

    [Column("isAdult")]
    public bool? IsAdult { get; set; }

    [Column("startYear")]
    public short? StartYear { get; set; }

    [Column("endYear")]
    public short? EndYear { get; set; }

    [Column("runtimeMinutes")]
    public short? RuntimeMinutes { get; set; }

    [InverseProperty("ParentTitle")]
    public virtual ICollection<Episode> EpisodeParentTitles { get; set; } = new List<Episode>();

    [InverseProperty("Title")]
    public virtual Episode? EpisodeTitle { get; set; }

    [InverseProperty("Title")]
    public virtual Rating? Rating { get; set; }

    [InverseProperty("TitleNavigation")]
    public virtual ICollection<TitleAlias> TitleAliases { get; set; } = new List<TitleAlias>();

    [ForeignKey("TitleId")]
    [InverseProperty("Titles")]
    public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();

    [ForeignKey("TitleId")]
    [InverseProperty("Titles")]
    public virtual ICollection<Name> Names { get; set; } = new List<Name>();

    [ForeignKey("TitleId")]
    [InverseProperty("Titles1")]
    public virtual ICollection<Name> Names1 { get; set; } = new List<Name>();

    [ForeignKey("TitleId")]
    [InverseProperty("TitlesNavigation")]
    public virtual ICollection<Name> NamesNavigation { get; set; } = new List<Name>();
}
