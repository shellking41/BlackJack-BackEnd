using BlackJack.Models;
using BlackJack.Repository;

namespace BlackJack.Service
{
    public interface IStatisticService
    {
        Statistic GetStatistic(int id);

        ICollection<Statistic> GetStatisticByUserId(int id);

        ICollection<Statistic> GetAllStatistics();
    }

    public class StatisticService : IStatisticService
    {
        private readonly IStatisticRepository _repository;

        public StatisticService(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public Statistic GetStatistic(int id)
        {
            return _repository.GetStatistic(id);
        }

        public ICollection<Statistic> GetStatisticByUserId(int id)
        {
            return _repository.GetStatisticByUserId(id);
        }

        public ICollection<Statistic> GetAllStatistics()
        {
            return _repository.GetAllStatistics();
        }
    }
}
