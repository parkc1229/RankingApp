using System;
using RankingApp.Models;

namespace RankingApp.DAL
{
	
	public interface IItemModelRepository : IDisposable
	{
		IEnumerable<ItemModel> GetItems();
		ItemModel GetItemByID(int itemId);
		void InsertItem(ItemModel item);
		void DeleteItem(int itemId);
		void UpdateItem(ItemModel item);
		void Save();
	}
	
}

