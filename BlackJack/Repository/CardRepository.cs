using BlackJack.Data;
using BlackJack.Models;

namespace BlackJack.Repository
{//itt erem el a adatbázis tábláinak a adatait
    public interface ICardRepository
    {
        
        Card GetCard(int id);
  
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

       
    }
}
