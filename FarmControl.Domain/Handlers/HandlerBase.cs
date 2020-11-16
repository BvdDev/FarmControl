using FarmControl.Domain.Repositories;
using FarmControl.Data.Dto;
using System;
using AutoMapper;

namespace FarmControl.Domain.Handlers
{
	public abstract class HandlerBase<T, TDto> : IHandler<T, TDto> where TDto : EntityDto where T: class
	{
		protected readonly UnitOfWork UnitOfWork;

		protected abstract RepositoryBase<T> Repository { get; }

		protected HandlerBase()
		{
			UnitOfWork = new UnitOfWork();
		}

		public void Update(TDto entity)
		{
			var domainEntity = Mapper.Map<TDto, T>(entity);
			Repository.Update(domainEntity);
			UnitOfWork.SaveChanges();
		}

		public void Add(TDto entity)
		{
			if (entity.Id == Guid.Empty)
			{
				entity.Id = Guid.NewGuid();
			}
			entity.Created = DateTime.Now;

			var domainEntity = Mapper.Map<TDto, T>(entity);

			Repository.Add(domainEntity);
			UnitOfWork.SaveChanges();
		}

		public void Delete(TDto entity)
		{
			var domainEntity = Mapper.Map<TDto, T>(entity);

			Repository.Delete(domainEntity);
			UnitOfWork.SaveChanges();
		}
	}
}
