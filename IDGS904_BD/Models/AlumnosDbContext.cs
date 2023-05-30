using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IDGS904_BD.Models
{
    public class AlumnosDBContext : DbContext
    {
        private static string connection = "DefaultConnection";

        public AlumnosDBContext() : base(connection) { }

        public DbSet<Alumnos> Alumnos { get; set; }
    }
}