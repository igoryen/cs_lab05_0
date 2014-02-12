using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5.ViewModels {

  public class RepoGenre : RepositoryBase {



    public IEnumerable<GenresForList> getForList() {
      var ls = dc.Genres.OrderBy(n => n.Id);
      //var ls = this.Directors.OrderBy(n => n.Id);


      List<GenresForList> rls = new List<GenresForList>();

      foreach (var item in ls) {
        GenresForList gfl = new GenresForList();
        gfl.Id = item.Id;
        gfl.Name = item.Name;
        rls.Add(gfl);
      }

      return rls;
    }


    public GenreFull getGenreFull(int? id) {
      var g = dc.Genres.FirstOrDefault(n => n.Id == id);
      //var dir = Directors.FirstOrDefault(n => n.Id == id);

      GenreFull gf = new GenreFull();
      gf.Id = g.Id;
      gf.Name = g.Name;
      gf.Movies = RepoMovie.getMoviesForList(g.Movies);

      return gf;

    }

    public IEnumerable<GenreFull> getGenresFull() {

      var gg = dc.Genres.Include("Genres").OrderBy(n => n.Name);
      //var st = this.Students.OrderBy(n => n.LastName);
      List<GenreFull> rls = new List<GenreFull>();

      foreach (var item in gg) {
        GenreFull row = new GenreFull();

        row.Id = item.Id;
        row.Name = item.Name;
        row.Movies = RepoMovie.getMoviesForList(item.Movies);

        rls.Add(row);  // 85
      }
      return rls; // 90
    }


  }
}

//getForList()
//getGenresFull()
//getGenreFull()
//Genres (not needed if db is used)
