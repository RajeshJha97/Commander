﻿using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Platform> Platforms { get; set; }
    }
}
