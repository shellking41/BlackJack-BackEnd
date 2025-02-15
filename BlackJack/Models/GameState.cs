using System.ComponentModel.DataAnnotations.Schema;

namespace BlackJack.Models
{
    public class GameState
    {
        public int Id { get; set; }
        public bool isGameOver { get; set; }

        public string State { get; set; }

        public double CurrentBet { get; set; }

       
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

    }
}
