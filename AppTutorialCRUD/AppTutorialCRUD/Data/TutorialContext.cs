using AppTutorialCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace AppTutorialCRUD.Data
{
    class TutorialContext : DbContext
    {

        public DbSet<TutorialModel>TbTutorials { get; set; }
        public TutorialContext ()
        {
            SQLitePCL.Batteries_V2.Init();
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Tutoriales.db3");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

    }
}
