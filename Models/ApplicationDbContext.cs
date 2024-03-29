﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Tournament> Tournament { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}
