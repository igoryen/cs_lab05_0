using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab5.Models;

namespace Lab5.ViewModels {

  public class RepoMovie : RepositoryBase {



    public IEnumerable<MoviesForList> getForList() {
      var ls = dc.Movies.OrderBy(n => n.Id);
      //var ls = this.Directors.OrderBy(n => n.Id);


      List<MoviesForList> rls = new List<MoviesForList>();

      foreach (var item in ls) {
        MoviesForList mfl = new MoviesForList();
        mfl.Id = item.Id;
        mfl.Name = item.Name;
        rls.Add(mfl);
      }

      return rls;
    }


    public MovieFull getMovieFull(int? id) {
      var m = dc.Movies.FirstOrDefault(n => n.Id == id);
      //var dir = Directors.FirstOrDefault(n => n.Id == id);

      MovieFull mf = new MovieFull();
      mf.Id = m.Id;
      mf.Title = m.Title;
      mf.TicketPrice = m.TicketPrice;
      mf.Director = m.Director;
      mf.Genres = RepoGenre.getGenresForList(m.Genres);

      return mf;

    }

    public IEnumerable<MovieFull> getMoviesFull() {

      var mm = dc.Movies.Include("Movies").OrderBy(n => n.Title);
      //var st = this.Students.OrderBy(n => n.LastName);
      List<MovieFull> rls = new List<MovieFull>();

      foreach (var item in mm) {
        MovieFull row = new MovieFull();

        row.Id = item.Id;
        row.Name = item.Name;
        row.TicketPrice = item.TicketPrice;
        row.Director = item.Director;
        row.Movies = RepoGenre.getGenresForList(item.Genres);

        rls.Add(row);  // 85
      }
      return rls; // 90
    }


    public static List<MoviesForList> getMoviesForList(List<Lab5.Models.Movie> ls) {
      List<MoviesForList> nls = new List<MoviesForList>();

      foreach (var item in ls) {
        MoviesForList mfl = new MoviesForList();
        mfl.Id = item.Id;
        mfl.Title = item.Title;
        nls.Add(mfl);
      }

      return nls;
    }


    public MovieFull createMovie(MovieFull mf, string ids) {
      //instantiate new movie
      Movie m = new Movie();
      m.Id = mf.Id;
      m.Title = mf.Title;
      m.TicketPrice = mf.TicketPrice;
      m.Director = mf.Director;

      //create a list of ints
      List<Int32> ls = new List<int>();

      //the format of ids is ("n,n,n,...") where n is an numeric character
      //split the string into an array of individual characters
      var nums = ids.Split(',');

      //convert each character to an int32 and store in ls
      foreach (var item in nums) {
        ls.Add(Convert.ToInt32(item));
      }

      //iterate through ls and for each id in the list, add a Course to the student's Courses collection
      foreach (var item in ls) {
        m.Genres.Add(dc.Genres.FirstOrDefault(n => n.Id == item));
      }
      //add the student to the DataContext
      dc.Students.Add(m);

      //savechanges is the equivalent to a database commit statement
      dc.SaveChanges();

      //return a copy of the new Student as a StudentFull
      return getMovieFull(m.Id);
    }

    /*
    public MovieFull createMovie(MovieFull mf) {
      //instantiate new student
      Student stu = new Student(st.FirstName, st.LastName, st.Phone, st.StudentNumber);

      dc.Students.Add(stu);

      //savechanges is the equivalent to a database commit statement
      dc.SaveChanges();

      //return a copy of the new Student as a StudentFull
      return getStudentFull(stu.Id);
    }
     */



  }
}
