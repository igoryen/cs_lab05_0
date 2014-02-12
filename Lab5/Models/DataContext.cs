using System.Data.Entity;

namespace Lab5.Models {
  public class DataContext : DbContext {
    public DataContext() : base("name=DataContext") { }


    public DbSet<Director> Directors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }

    public System.Data.Entity.DbSet<Lab5.ViewModels.MovieFull> MovieFulls { get; set; }
  }
}