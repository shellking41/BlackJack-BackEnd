using BlackJack.Data;
using BlackJack.Models;

namespace BlackJack.Repository
{//itt erem el a adatbázis tábláinak a adatait
    public interface ICardRepository
    {
        
        Card GetCard(int id);
       ICollection<Card> GetCards();
        ICollection<Card> GetCardsByUserId(int id);
    }
    public class CardRepository : ICardRepository
    {
        private readonly DataContext _dataContext;

        public CardRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Card GetCard(int id)
        {
            return _dataContext.Cards.Find(id);
        }
        public ICollection<Card> GetCards() 
        {
            return _dataContext.Cards.OrderBy(c => c.Id).ToList();
        }
       
        public ICollection<Card> GetCardsByUserId(int id)
        {
            return _dataContext.Cards.Where(c => c.User.Id == id).ToList();
        }
    }
}
