
namespace Domain.Interfaces
{
    public interface IHospital
    {
        Guid Id { get; set; }
        string HospitalName { get; set; }
        Region Region { get; set; }
        HospitalType HospitalType { get; set; }
        DateTimeOffset CreatedDate { get; set; }
    }
}
