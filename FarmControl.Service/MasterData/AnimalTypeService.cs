using FarmControl.Data.Dto.MasterData;
using FarmControl.Domain;
using FarmControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace FarmControl.Service.MasterData
{
	public class AnimalTypeService
	{
		public static List<AnimalTypeDto> GetAll()
		{
			using var unitOfWork = new UnitOfWork();
			return unitOfWork.RepoFactory.AnimalTypeRepository.Repository.OrderBy(x => x.Code).ToList().ToDto();
		}

		public static async Task<AnimalTypeDto> GetById(Guid id)
		{
			using var unitOfWork = new UnitOfWork();
			var result = await unitOfWork.RepoFactory.AnimalTypeRepository.GetById(id);
			return result.ToDto();
		}
	}
}
