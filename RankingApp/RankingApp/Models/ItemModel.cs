using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace RankingApp.Models
{
    /*
    public class RankingContext : DbContext
    {
        public DbSet<ItemModel> ItemList { get; set; }
        public DbSet<RankingsModel> RankingsList { get; set; }

        public string DbPath { get; }

        public RankingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "ranking.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
    */

    public class ItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageId { get; set; }
        public int Ranking { get; set; }
        public int ItemType { get; set; }

        //public int RankedId { get; set; }
       // public RankingsModel RankingsModel { get; set; }
    }

    /*
    public class RankingsModel
    {
        
        public int RankingsModelId { get; set; }

        public string Url { get; set; }

        public List<ItemModel> Ranked { get; } = new();


    }
    */

}

