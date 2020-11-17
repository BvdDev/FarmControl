using System.Runtime.Serialization;

namespace FarmControl.Data.Dto.MasterData
{
    [DataContract]
    public class MedicineDto : EntityDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public int MaxDosage { get; set; }
    }
}
