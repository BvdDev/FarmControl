using FarmControl.Domain.Models;
using FarmControl.Domain.Repositories;

namespace FarmControl.Domain.Handlers.MasterData
{
	public class MedicineHandler : HandlerBase<Medicine>
	{
		protected override RepositoryBase<Medicine> Repository => UnitOfWork.RepoFactory.MedicineRepository;
	}
}
