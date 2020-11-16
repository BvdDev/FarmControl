using AutoMapper;
using FarmControl.Data.Dto.MasterData;
using FarmControl.Domain.Models;
using System.Collections.Generic;

namespace FarmControl.Domain
{
    public static class Converter
    {
        public static List<T> ToDto<D, T>(List<D> items)
        {
            var result = new List<T>();
            foreach (var item in items)
            {
                result.Add(Mapper.Map<D, T>(item));
            }

            return result;
        }

        public static AnimalTypeDto ToDto(this AnimalType animalType)
        {
            return Mapper.Map<AnimalType, AnimalTypeDto>(animalType);
        }

        public static List<AnimalTypeDto> ToDto(this List<AnimalType> animalTypes)
        {
            return ToDto<AnimalType, AnimalTypeDto>(animalTypes);
        }
    }
}
