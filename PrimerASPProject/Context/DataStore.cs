using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using MySql.Data.Entity;
using PrimerASPProject.Models;

namespace PrimerASPProject.Context
{
    public class DataStore : System.Data.Entity.DbContext
    {
        public DbSet<Producto> Productos { set; get; }

    }
}