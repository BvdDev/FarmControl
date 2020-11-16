using FarmControl.Data.Dto.MasterData;
using FarmControl.Domain.Models;
using FarmControl.Domain.Repositories;
using AutoMapper;

namespace FarmControl.Domain.Handlers.MasterData
{
    public class AnimalTypeHandler : HandlerBase<AnimalType, AnimalTypeDto>
	{
		protected override RepositoryBase<AnimalType> Repository => UnitOfWork.RepoFactory.AnimalTypeRepository;
	}
}
