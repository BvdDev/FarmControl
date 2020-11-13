using FarmControl.Domain.Models;
using FarmControl.Service.MasterData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace FarmControl.Web.Controllers
{
	[Authorize]
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
			_logger.LogInformation("GetAnimals");
			return new AnimalTypeService().GetAll();
		}
	}
}
