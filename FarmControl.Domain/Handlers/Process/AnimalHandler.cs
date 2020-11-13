using FarmControl.Domain.Models;
using FarmControl.Domain.Repositories;

namespace FarmControl.Domain.Handlers.Process
{
	public class AnimalHandler : HandlerBase<Animal>
	{
		protected override RepositoryBase<Animal> Repository => UnitOfWork.RepoFactory.AnimalRepository;
	}
}
