using FarmControl.Domain.Models;
using FarmControl.Domain.Repositories;
using AutoMapper;
using FarmControl.Data.Dto.Process;

namespace FarmControl.Domain.Handlers.Process
{
	public class AnimalHandler : HandlerBase<Animal, AnimalDto>
	{
		protected override RepositoryBase<Animal> Repository => UnitOfWork.RepoFactory.AnimalRepository;
	}
}
