using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab5.ViewModels {

  public class GenresForList {
    [Key]
    public int Id { get; set; }

    [Required]
    //[RegularExpression("^[0][0-9]{8}$", ErrorMessage = "0 followed by 8 digits")]
    public string Name { get; set; }
  }


  public class GenreFull : GenresForList {

    public GenreFull() {
      this.Movies = new List<MoviesForList>();
    }

    public List<MoviesForList> Movies { get; set; }
  }


}


