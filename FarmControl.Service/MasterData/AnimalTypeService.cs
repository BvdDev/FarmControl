using FarmControl.Domain;
using FarmControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmControl.Service.MasterData
{
	public class AnimalTypeService
	{
		public static List<AnimalType> GetAll()
		{
			using var unitOfWork = new UnitOfWork();
			return unitOfWork.RepoFactory.AnimalTypeRepository.Repository.OrderBy(x => x.Code).ToList();
		}

		public static AnimalType GetById(Guid id)
		{
			using var unitOfWork = new UnitOfWork();
			return unitOfWork.RepoFactory.AnimalTypeRepository.GetById(id);
		}
	}
}
