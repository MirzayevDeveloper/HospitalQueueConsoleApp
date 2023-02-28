
namespace Domain.Interfaces
{
    public interface IQueue
    {
        Guid Id { get; set; }
        IllnessType Illness { get; set; }
        Region Region { get; set; }
        Guid DoctorId { get; set; }
        Guid HospitalId { get; set; }
        Guid PatientId { get; set; }
        DateTimeOffset QueueDateTime { get; set; }
        DateTimeOffset QueueEndDateTime { get; }
        string Description { get; set; }
    }
}
