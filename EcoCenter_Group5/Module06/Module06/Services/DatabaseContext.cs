using EcoCenter_Group5.Model;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Xamarin.Essentials;

namespace EcoCenter_Group5.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ActionModel> Actions { get; set; }

        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Actions.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }


    }
}
