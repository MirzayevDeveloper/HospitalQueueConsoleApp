using Domain.Interfaces;

namespace Application.Interfaces
{
    public interface IHospitalService
    {
        bool AddHospitalAsync(IHospital hospital);
        bool DeleteHospitalByIdAsync(Guid hospitalId);
        bool UpdateHospitalById(Guid hospitalId);
        IHospital GetHospitalById(Guid hospitalId);
        IList<IHospital> GetAllHospital();
    }
}
