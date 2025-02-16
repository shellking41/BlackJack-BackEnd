using BlackJack.Data;
using BlackJack.Models;

namespace BlackJack.Repository
{
    public interface IGameStateRepository
    {
        GameState GetGameState(int id);
        GameState GetGameStateByUserId(int id);
        ICollection<GameState> GetAllGameStates();

    }

    public class GameStateRepository : IGameStateRepository
    {
        private readonly DataContext _dataContext;

        public GameStateRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public GameState GetGameState(int id)
        {
            return _dataContext.GameStates.Find(id);


        }

        public GameState GetGameStateByUserId(int id)
        {
            return _dataContext.GameStates.FirstOrDefault(gs => gs.User.Id == id);
        }

        public ICollection<GameState> GetAllGameStates()
        {
            return _dataContext.GameStates.OrderBy(gs => gs.Id).ToList();
        }
    }
}
