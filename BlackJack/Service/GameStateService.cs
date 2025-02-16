using BlackJack.Models;
using BlackJack.Repository;

namespace BlackJack.Service
{
    public interface IGameStateService
    {
        GameState GetGameState(int id);
        GameState GetGameStateByUserId(int id);
        ICollection<GameState> GetAllGameStates();
    }

    public class GameStateService : IGameStateService
    {
        private readonly IGameStateRepository _repository;

        public GameStateService(IGameStateRepository repository)
        {
            _repository = repository;
        }

        public GameState GetGameStateByUserId(int id)
        {
            return _repository.GetGameStateByUserId(id);
        }

        public GameState GetGameState(int id)
        {
            return _repository.GetGameState(id);
        }

        public ICollection<GameState> GetAllGameStates() 
        {
            return _repository.GetAllGameStates();
        }
    }
}
