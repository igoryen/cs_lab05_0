using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab5.Models;

namespace Lab5.ViewModels {

  public class RepositoryBase {

    protected DataContext dc;

    public RepositoryBase() {

      dc = new DataContext();

      // Turn off the Entity Framework (EF) proxy creation features
      // We do NOT want the EF to track changes - we'll do that ourselves
      dc.Configuration.ProxyCreationEnabled = false;

      // Also, turn off lazy loading...
      // We want to retain control over fetching related objects
      dc.Configuration.LazyLoadingEnabled = false;
    }
  }
}