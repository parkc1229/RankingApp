using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using RankingApp.Models;
using Microsoft.EntityFrameworkCore;
using RankingApp.Data;

namespace RankingApp.DAL
{
    public class ItemModelRepository : IItemModelRepository, IDisposable
    {
        private DataContext context;

        public ItemModelRepository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<ItemModel> GetItems()
        {
            return (IEnumerable<ItemModel>)context.ItemModels.ToList();
        }

        public ItemModel GetItemByID(int id)
        {
            return context.ItemModels.Find(id);
        }

        public void InsertItem(ItemModel item)
        {
            context.ItemModels.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            ItemModel item = context.ItemModels.Find(itemId);
            context.ItemModels.Remove(item);
        }

        public void UpdateItem(ItemModel item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}