﻿using HockeyFun.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyFun.Data
{
    public static class DummyData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                Team.GetTeams()
            );
            modelBuilder.Entity<Player>().HasData(
                Player.GetPlayers()
            );
        }
    }
}
