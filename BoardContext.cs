﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_TODO_Application.Database;

namespace WPF_TODO_Application
{
    public class BoardContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=WPF_TODO_Board;Username=postgres;Password=123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .Property(c => c.CardId)
                .ValueGeneratedOnAdd();
        }

        public DbSet<Card> Board { get; set; }
    }
}
