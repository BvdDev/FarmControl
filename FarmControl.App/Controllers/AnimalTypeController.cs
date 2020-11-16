using AutoMapper;
using FarmControl.Data.Dto.MasterData;
using FarmControl.Domain.Handlers.MasterData;
using FarmControl.Domain.Models;
using FarmControl.Service.MasterData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
		public IEnumerable<AnimalTypeDto> GetAll()
		{
			_logger.LogInformation("GetAllAnimalTypes");
			return AnimalTypeService.GetAll().ToArray();
		}

		[HttpGet("{Id}")]
		public async Task<AnimalTypeDto> GetById([FromRoute] Guid id)
		{
			_logger.LogInformation($"GetAnimalTypeById: {id}");
			return await AnimalTypeService.GetById(id);
		}

		[HttpPost]
		public void Add([FromBody] AnimalTypeDto animalType)
		{
			_logger.LogInformation($"Add animal, Name: {animalType.Name}");
			new AnimalTypeHandler().Add(animalType);
		}
	}
}
