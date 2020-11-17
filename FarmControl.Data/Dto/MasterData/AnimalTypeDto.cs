using System.Runtime.Serialization;

namespace FarmControl.Data.Dto.MasterData
{
    [DataContract]
    public class AnimalTypeDto : EntityDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Code { get; set; }
    }
}
