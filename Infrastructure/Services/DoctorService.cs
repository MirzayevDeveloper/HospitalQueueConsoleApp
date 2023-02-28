using Application.Interfaces;
using Domain.Interfaces;

namespace Infrastructure.Services
{
    public class DoctorService : IDoctorService
    {
        public bool AddDoctorAsync(IDoctor doctor)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDoctorByIdAsync(Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public IList<IDoctor> GetAllDoctorAsync()
        {
            throw new NotImplementedException();
        }

        public IDoctor GetDoctorById(Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDoctor(IDoctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
