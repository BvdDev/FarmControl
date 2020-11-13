using FarmControl.Domain;
using FarmControl.Domain.Models;
using System;
using System.Linq;

namespace FarmControl.Service
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var animalType = new AnimalType
			{
				Id = Guid.NewGuid(),
				Code = "02",
				Name = "name02",
				Created = DateTime.Now
			};

			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.RepoFactory.AnimalTypeRepository.Add(animalType);
				unitOfWork.SaveChanges();
			}

			var exitingtype = new UnitOfWork().RepoFactory.AnimalTypeRepository.GetAll().FirstOrDefault();
			if (exitingtype != null)
			{
				Console.WriteLine($"{exitingtype.Name}");
			}
		}
	}
}
