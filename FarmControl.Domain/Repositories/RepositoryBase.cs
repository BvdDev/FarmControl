using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmControl.Domain.Repositories
{
	public class RepositoryBase<T> : IRepositoryBase where T : class
	{
		protected readonly UnitOfWork UnitOfWork;

		public IQueryable<T> Repository => UnitOfWork.Context.Repository<T>();

		public RepositoryBase(UnitOfWork unitOfWork)
		{
			UnitOfWork = unitOfWork;
		}

		public T GetById(Guid id)
		{
			return UnitOfWork.Context.Set<T>().Find(id);
		}

		public IEnumerable<T> GetAll()
		{
			return UnitOfWork.Context.Set<T>().ToList();
		}

		public void Add(T entity)
		{
			UnitOfWork.Context.Set<T>().Add(entity);
		}

		public void Update(T entity)
		{
			UnitOfWork.Context.Set<T>().Update(entity);
		}

		public void Delete(T entity)
		{
			UnitOfWork.Context.Set<T>().Remove(entity);
		}

		public void Save()
		{
			UnitOfWork.Context.SaveChanges();
		}
	}

	public interface IRepositoryBase
	{

	}
}
