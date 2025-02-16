using BlackJack.Models;
using BlackJack.Repository;

namespace BlackJack.Service
{//itt tudjuk manipulalni a adatokat
    public interface ICardService
    {
        Card GetCard(int id);
       ICollection<Card> GetCards();
        ICollection<Card> GetCardsByUserId(int id);
    }

    public class CardService : ICardService
    {

        private readonly ICardRepository _repository;

        public CardService(ICardRepository repository)
        {
            _repository = repository;
        }
        
        public Card GetCard(int id)
        {
            return _repository.GetCard(id);
        }
        public ICollection<Card> GetCards() 
        {
            return _repository.GetCards();
        }
        public ICollection<Card> GetCardsByUserId(int id)
        {
            return _repository.GetCardsByUserId(id);
        }
    }
}
