using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WhoWantsToBeAMillionaire.Model
{
    public class MillionaireContext : DbContext
    {
        public DbSet<DBQuestion> Questions { get; set; }
        public DbSet<DBAchievement> Achievements { get; set; }

        public string DbPath { get; }

        public MillionaireContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "millonaire.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class DBQuestion
    {
        public int Id { get; set; }
        public string QText { get; set; }
        public string QAnswerA { get; set; }
        public string QAnswerB { get; set; }
        public string QAnswerC { get; set; }
        public string QAnswerD { get; set; }
        public int QRightAnswer { get; set; }
        public int QLevel { get; set; }
    }

    public class DBAchievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Achieve { get; set; }
    }
}
