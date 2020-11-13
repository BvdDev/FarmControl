using FarmControl.Domain.Models;
using FarmControl.Service.MasterData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FarmControl.Website.Controllers.MasterData
{
	[ApiController]
	[Route("[controller]")]
	public class AnimalTypeController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<AnimalType> GetAll()
		{
			return new AnimalTypeService().GetAll();
		}

		[HttpGet]
		public AnimalType GetById(Guid id)
		{
			return new AnimalTypeService().GetById(id);
		}
	}
}
