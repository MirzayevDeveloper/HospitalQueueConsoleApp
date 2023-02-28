using Domain.Interfaces;

namespace Application.Interfaces
{
    public interface IPatientService
    {
        bool AddPatientAsync(IPatient queue);
        bool RemovePatientByIdAsync(Guid queueId);
        bool UpdatePatientById(Guid queueId);
        IQueue ReadPatientById(Guid queueId);
    }
}
