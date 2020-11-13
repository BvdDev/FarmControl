using FarmControl.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmControl.Domain.Repositories.Process
{
	public class AnimalRepository : RepositoryBase<Animal>
	{
		public AnimalRepository(UnitOfWork unitOfWork)
			: base(unitOfWork)
		{
		}
	}
}
