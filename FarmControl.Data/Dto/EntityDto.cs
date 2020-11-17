using System;
using System.Runtime.Serialization;

namespace FarmControl.Data.Dto
{
    [DataContract]
    public abstract class EntityDto
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
    }
}
