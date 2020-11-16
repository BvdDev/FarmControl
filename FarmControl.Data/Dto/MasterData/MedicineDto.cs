namespace FarmControl.Data.Dto.MasterData
{
    public class MedicineDto : EntityDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int MaxDosage { get; set; }
    }
}
