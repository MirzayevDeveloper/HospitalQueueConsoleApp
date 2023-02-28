using Domain.Enums;
using Domain.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models.Hospitals
{
    public class Hospital : IHospital
    {
        public Guid Id { get; set; }

        [JsonProperty("Hospital name")]
        public string HospitalName { get; set; } = string.Empty;

        [Required]
        public Region Region { get; set; } = Region.Other;

        [JsonProperty("Hospital type")]
        public HospitalType HospitalType { get; set; } = HospitalType.Other;

        public DateTimeOffset CreatedDate { get; set; }
    }
}
