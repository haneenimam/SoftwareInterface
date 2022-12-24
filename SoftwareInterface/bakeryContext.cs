using Microsoft.EntityFrameworkCore;
using SoftwareInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp22.db
{
    public class bakeryContext : DbContext
    {
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = bakery.db");
        }
        public DbSet<Account> Accounts { get; set;}
        public DbSet<Orrder> Orrders { get; set;}   
        public DbSet<User> users { get; set; }
        public DbSet<item> items { get; set; }
        public DbSet<feedback> feedbacks { get; set; }
    }
}
