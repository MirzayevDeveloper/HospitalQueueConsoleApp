using Domain.Enums;
using Domain.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models.Queues
{
    public class Queue : IQueue
    {
        public Guid Id { get; set; }
        public IllnessType Illness { get; set; } = IllnessType.Other;

        [Required]
        public Region Region { get; set; } = Region.Other;
        public Guid DoctorId { get; set; }
        public Guid HospitalId { get; set; }
        public Guid PatientId { get; set; }

        [JsonProperty("Queue datetime")]
        public DateTimeOffset QueueDateTime { get; set; }

        [JsonProperty("Queue end datetime")]
        public DateTimeOffset QueueEndDateTime { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
