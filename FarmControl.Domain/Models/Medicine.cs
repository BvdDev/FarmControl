using System;

#nullable disable

namespace FarmControl.Domain.Models
{
    public partial class Medicine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int MaxDosage { get; set; }
        public DateTime Created { get; set; }
    }
}
