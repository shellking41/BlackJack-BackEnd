using System.ComponentModel.DataAnnotations.Schema;

namespace BlackJack.Models
{
    public class User
    {
        public int Id { get; set; }
        public double CurrentMoney { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
      
        public  ICollection<Card> Cards { get; set; }

        public ICollection<Statistic> Statistics { get; set; }
        public int? GameStateId { get; set; }
       
        public GameState? GameState { get; set; }

      
    }
}
