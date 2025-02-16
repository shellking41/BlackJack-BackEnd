using BlackJack.Data;
using BlackJack.Models;

namespace BlackJack.Repository
{
    public interface IStatisticRepository
    {
        Statistic GetStatistic(int id);

        ICollection<Statistic> GetStatisticByUserId(int id);

        ICollection<Statistic> GetAllStatistics();
    }

    public class StatisticRepository : IStatisticRepository
    {
        private readonly DataContext _dataContext;

        public StatisticRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Statistic GetStatistic(int id)
        {
            return _dataContext.Statistics.Find(id);
        }

        public ICollection<Statistic> GetStatisticByUserId(int id)
        {
            return _dataContext.Statistics
                .Where(s=>s.User.Id==id)
                .OrderBy(s=>s.RoundDate)
                .ToList();
        }

        public ICollection<Statistic> GetAllStatistics()
        {
            return _dataContext.Statistics.OrderBy(s=>s.RoundDate).ToList();
        }
    }
}
