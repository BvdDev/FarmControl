using AutoMapper;
using FarmControl.Data.Dto.MasterData;
using FarmControl.Data.Dto.Process;
using FarmControl.Domain.Models;
using System;

namespace FarmControl.Domain
{
    public static class AutoMapperConfiguration 
    {
        private static readonly object _lockObject = new object();
        private static bool isInitialized = false;

        internal static Action<IMapperConfigurationExpression> GetAutoMapperConfiguration()
        {
            return (config) =>
            {
                config.CreateMap<AnimalType, AnimalTypeDto>();
                config.CreateMap<AnimalTypeDto, AnimalType>();

                config.CreateMap<Animal, AnimalDto>();
                config.CreateMap<AnimalDto, Animal>();

                config.CreateMap<Medicine, MedicineDto>();
                config.CreateMap<MedicineDto, Medicine>();
            };
        }

        public static void Initialize()
        {
            lock (_lockObject)
            {
                if (isInitialized) return;

                Mapper.Initialize(GetAutoMapperConfiguration());
                isInitialized = true;
            }
        }
    }
}
