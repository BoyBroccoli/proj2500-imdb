using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace prog2500_imdb.Models;

public partial class Genre
{
    [Key]
    [Column("GenreID")]
    public int GenreId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [ForeignKey("GenreId")]
    [InverseProperty("Genres")]
    public virtual ICollection<Title> Titles { get; set; } = new List<Title>();
}
