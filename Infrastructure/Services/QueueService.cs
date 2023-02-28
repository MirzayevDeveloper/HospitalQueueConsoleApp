using Application.Interfaces;
using Domain.Interfaces;

namespace Infrastructure.Services
{
    public class QueueService : IQueueService
    {
        public bool AddQueueAsync(IQueue queue)
        {
            throw new NotImplementedException();
        }

        public IList<IQueue> ReadAllQueues(Guid doctorId)
        {
            throw new NotImplementedException();
        }

        public IQueue ReadQueueById(Guid queueId)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllQueueAsync()
        {
            throw new NotImplementedException();
        }

        public bool RemoveQueueByIdAsync(Guid queueId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQueueById(Guid queueId)
        {
            throw new NotImplementedException();
        }
    }
}
