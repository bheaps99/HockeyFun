using System;
using System.Collections.Generic;
using System.Text;
using HockeyFun.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HockeyFun.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }

        public DbSet<Team> Teams{ get; set; }
        public DbSet<Player> Players { get; set; }


    }
}
