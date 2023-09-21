using System;
using RankingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace RankingApp.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}


		public DbSet<ItemModel> ItemModels { get; set; } = null;
	}
}

