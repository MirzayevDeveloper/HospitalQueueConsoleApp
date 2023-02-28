using Domain.Interfaces;

namespace Application.Interfaces
{
    public interface IQueueService
    {
        bool AddQueueAsync(IQueue queue);
        bool RemoveQueueByIdAsync(Guid queueId);
        void RemoveAllQueueAsync();
        bool UpdateQueueById(Guid queueId);
        IQueue ReadQueueById(Guid queueId);
        IList<IQueue> ReadAllQueues(Guid doctorId);
    }
}
