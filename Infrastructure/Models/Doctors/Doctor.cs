using Domain.Enums;
using Domain.Interfaces;

namespace Infrastructure.Models.Doctors
{
    public class Doctor : IDoctor
    {
        public IllnessType Specialty { get; set; } = IllnessType.Other;
        public Experience ExperienceInYear { get; set; } = Experience.None;
        public Guid Id { get ; set ; }
        public string Name { get ; set ; } = string.Empty;
        public int Age { get ; set ; }
        public string PassportId { get ; set ; } = string.Empty;
    }
}
