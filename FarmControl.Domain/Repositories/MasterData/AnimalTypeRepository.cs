using FarmControl.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmControl.Domain.Repositories.MasterData
{
	public class AnimalTypeRepository : RepositoryBase<AnimalType>
	{
		public AnimalTypeRepository(UnitOfWork unitOfWork)
			: base(unitOfWork)
		{
		}
	}
}
