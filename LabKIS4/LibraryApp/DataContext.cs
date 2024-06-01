using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {

        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Records> Records { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySql("server=localhost;user=root;password=root;database=library",
                new MySqlServerVersion(new Version(10, 3, 0)));
        }
    }
}
