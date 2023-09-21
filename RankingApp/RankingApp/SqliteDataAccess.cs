using System;
using RankingApp.Models;

namespace RankingApp
{
	public class SqliteDataAccess
	{
		public static List<ItemModel> LoadItems()
		{

		}

		public static void SaveItem(ItemModel item)
		{

		}

		private static string LoadConnectionString(string id = "DefaultConnection")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}

