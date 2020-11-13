using FarmControl.Domain.Models;
using FarmControl.Domain.Repositories;

namespace FarmControl.Domain.Handlers.MasterData
{
	public class AnimalTypeHandler : HandlerBase<AnimalType>
	{
		protected override RepositoryBase<AnimalType> Repository => UnitOfWork.RepoFactory.AnimalTypeRepository;
	}
}
