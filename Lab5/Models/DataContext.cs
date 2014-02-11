using System.Data.Entity;

namespace CodeFirstOne.Models {
  public class DataContext : DbContext {
    public DataContext() : base("name=DataContext") { }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Genre> Genres { get; set; }

    public System.Data.Entity.DbSet<CodeFirstOne.ViewModels.aaaFull> aaaFulls { get; set; }
  }
}