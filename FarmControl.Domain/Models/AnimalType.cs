using System;
using System.Collections.Generic;

#nullable disable

namespace FarmControl.Domain.Models
{
    public partial class AnimalType
    {
        public AnimalType()
        {
            Animals = new HashSet<Animal>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? Created { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
