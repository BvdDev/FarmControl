using System;

namespace FarmControl.Data.Dto
{
    public abstract class EntityDto
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
    }
}
