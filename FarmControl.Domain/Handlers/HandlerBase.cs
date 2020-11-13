using FarmControl.Domain.Repositories;

namespace FarmControl.Domain.Handlers
{
	public abstract class HandlerBase<T> : IHandler<T> where T : class
	{
		protected readonly UnitOfWork UnitOfWork;

		protected abstract RepositoryBase<T> Repository { get; }

		protected HandlerBase()
		{
			UnitOfWork = new UnitOfWork();
		}

		public void Update(T entity)
		{
			Repository.Update(entity);
			UnitOfWork.SaveChanges();
		}

		public void Add(T entity)
		{
			Repository.Add(entity);
			UnitOfWork.SaveChanges();
		}

		public void Delete(T entity)
		{
			Repository.Delete(entity);
			UnitOfWork.SaveChanges();
		}
	}
}
