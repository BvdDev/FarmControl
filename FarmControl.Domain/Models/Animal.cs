using System;

#nullable disable

namespace FarmControl.Domain.Models
{
    public partial class Animal
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public Guid AnimalTypeId { get; set; }

        public virtual AnimalType AnimalType { get; set; }
    }
}
