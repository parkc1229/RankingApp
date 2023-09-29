using System;
using RankingApp.Models;
using RankingApp.Data;

namespace RankingApp.DAL
{
	public class UnitOfWork : IDisposable
	{
		private DataContext context = new DataContext();
		private GenericRepository<ItemModel> itemRepository;

		public GenericRepository<ItemModel> ItemRepository
		{
			get
			{
				if (this.itemRepository == null)
				{
					this.itemRepository = new GenericRepository<ItemModel>(context);
				}
				return itemRepository;
			}
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

