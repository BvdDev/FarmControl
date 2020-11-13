using FarmControl.Domain.Models;
using FarmControl.Service.MasterData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace FarmControl.App.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AnimalTypeController : ControllerBase
	{
		private readonly ILogger<AnimalTypeController> _logger;

		public AnimalTypeController(ILogger<AnimalTypeController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IEnumerable<AnimalType> Get()
		{
			_logger.LogInformation("GetAllAnimalTypes");
			return AnimalTypeService.GetAll().ToArray();
		}
	}
}
