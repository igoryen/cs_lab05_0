using System.Data.Entity;

namespace CodeFirstOne.Models {
  public class DataContext : DbContext {
    public DataContext() : base("name=DataContext") { }

    public DbSet<A> As { get; set; }
    public DbSet<O> Os { get; set; }
    public DbSet<E> Es { get; set; }

    public System.Data.Entity.DbSet<CodeFirstOne.ViewModels.aaaFull> aaaFulls { get; set; }
  }
}