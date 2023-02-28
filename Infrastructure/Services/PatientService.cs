using Application.Interfaces;
using Domain.Interfaces;

namespace Infrastructure.Services
{
    public class PatientService : IPatientService
    {
        public bool AddPatientAsync(IPatient queue)
        {
            throw new NotImplementedException();
        }

        public IQueue ReadPatientById(Guid queueId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePatientByIdAsync(Guid queueId)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatientById(Guid queueId)
        {
            throw new NotImplementedException();
        }
    }
}
