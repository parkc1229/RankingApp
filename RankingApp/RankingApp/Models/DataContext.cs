using System;
using RankingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace RankingApp.Data
{
	public class DataContext : DbContext
	{
		public string DbPath { get; }

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
            
        }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "sqlite.db");
        }

        public DbSet<ItemModel> ItemModels { get; set; } = null;

        /*
		public class ItemModel
		{
            public int Id { get; set; }
            public string Title { get; set; }
            public int ImageId { get; set; }
            public int Ranking { get; set; }
            public int ItemType { get; set; }
        }
        */
	}
}

