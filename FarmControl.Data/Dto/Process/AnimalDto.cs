using System.Runtime.Serialization;

namespace FarmControl.Data.Dto.Process
{
    [DataContract]
    public class AnimalDto : EntityDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Code { get; set; }
    }
}
