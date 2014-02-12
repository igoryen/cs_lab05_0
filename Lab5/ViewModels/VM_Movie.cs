using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Lab5.Models;

namespace Lab5.ViewModels {


  public class MoviesForList {

    [Key]
    public int Id { get; set; }

    [Required]
    //[RegularExpression("^[0][0-9]{8}$", ErrorMessage = "0 followed by 8 digits")]
    public string Title { get; set; }
  }


  public class MovieFull : MoviesForList {

    public MovieFull() {
      this.Genres = new List<GenresForList>();
    }

    [Required]
    [StringLength(40, MinimumLength = 3)]
    [Display(Name = "Ticket Price")]
    public decimal TicketPrice { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    [Display(Name = "Name")]
    public Director Director { get; set; }

    public List<GenresForList> Genres { get; set; }
  }

}
