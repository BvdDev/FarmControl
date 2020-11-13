using FarmControl.Domain.Models;

namespace FarmControl.Domain.Repositories.MasterData
{
	public class MedicineRepository : RepositoryBase<Medicine>
	{
		public MedicineRepository(UnitOfWork unitOfWork)
			: base(unitOfWork)
		{
		}
	}
}
