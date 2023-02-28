using Domain.Enums;
using Domain.Interfaces;
using Newtonsoft.Json;

namespace Infrastructure.Models.Patients
{
    public class Patient : IPatient
    {
        public Guid Id { get ; set ; }
        public string Name { get ; set ; } = string.Empty;
        public int Age { get ; set ; }
        public string PassportId { get; set; } = string.Empty;
        public IllnessType Illness { get; set; }

        [JsonProperty("Illness date")]
        public DateTimeOffset IllnessOfDate { get; set; }
    }
}
