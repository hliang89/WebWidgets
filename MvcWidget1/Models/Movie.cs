using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcWidget1.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage="Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage="Release Date is required")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage="Genre is required")]
        public string Genre { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }

        [Required(ErrorMessage="Price is required")]
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; } //Not unlike a SqlDataCommand + DataAdapter rolled into 1
    }
}