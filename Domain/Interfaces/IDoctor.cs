namespace Domain.Interfaces
{
    public interface IDoctor : IPerson
    {
        IllnessType Specialty { get; set; }
        Experience ExperienceInYear { get; set; }
    }
}
