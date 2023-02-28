
namespace Domain.Interfaces
{
    public interface IPatient : IPerson
    {
        IllnessType Illness { get; set; }
        DateTimeOffset IllnessOfDate { get; set; }
    }
}
