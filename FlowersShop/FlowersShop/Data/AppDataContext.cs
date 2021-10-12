using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowersShop.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowersShop.Data
{
    public class AppDataContext:DbContext
    {
        public AppDataContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Flower> Flowers { get; set;}
        public DbSet<New> News { get; set; }
    }
}
