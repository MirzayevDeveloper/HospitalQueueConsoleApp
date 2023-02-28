using Application.Interfaces;
using Domain.Interfaces;

namespace Infrastructure.Services
{
    public class HospitalService : IHospitalService
    {
        public bool AddHospitalAsync(IHospital hospital)
        {
            throw new NotImplementedException();
        }

        public bool DeleteHospitalByIdAsync(Guid hospitalId)
        {
            throw new NotImplementedException();
        }

        public IList<IHospital> GetAllHospital()
        {
            throw new NotImplementedException();
        }

        public IHospital GetHospitalById(Guid hospitalId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateHospitalById(Guid hospitalId)
        {
            throw new NotImplementedException();
        }
    }
}
