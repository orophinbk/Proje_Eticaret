using EntityLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CoreEticaretDB;integrated security=true");
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Pay>? Pays { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Card>? Cards { get; set; }

    }
}
