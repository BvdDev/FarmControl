using FarmControl.Domain.Repositories.MasterData;
using FarmControl.Domain.Repositories.Process;
using System;
using System.Collections.Generic;

namespace FarmControl.Domain.Repositories
{
	public class RepoFactory
	{
		private readonly UnitOfWork _unitOfWork;

		internal RepoFactory(UnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public T CreateRepository<T>()
		{
			return (T)Activator.CreateInstance(typeof(T), _unitOfWork);
		}

		private readonly Dictionary<string, IRepositoryBase> _repositories = new Dictionary<string, IRepositoryBase>();

		public AnimalTypeRepository AnimalTypeRepository => GetRepo<AnimalTypeRepository>();
		public MedicineRepository MedicineRepository => GetRepo<MedicineRepository>();
		public AnimalRepository AnimalRepository => GetRepo<AnimalRepository>();

		internal T GetRepo<T>()
		{
			var typeName = typeof(T).FullName;
			if (!_repositories.ContainsKey(typeName))
			{
				_repositories[typeName] = (IRepositoryBase)CreateRepository<T>();
			}

			return (T)_repositories[typeName];
		}
	}
}
