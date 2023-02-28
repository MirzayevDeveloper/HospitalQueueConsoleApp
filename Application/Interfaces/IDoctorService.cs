using Domain.Interfaces;

namespace Application.Interfaces
{
    public interface IDoctorService
    {
        bool AddDoctorAsync(IDoctor doctor);
        IDoctor GetDoctorById(Guid doctorId);
        bool UpdateDoctor(IDoctor doctor);
        bool DeleteDoctorByIdAsync(Guid doctorId);
        IList<IDoctor> GetAllDoctorAsync();
    }
}
