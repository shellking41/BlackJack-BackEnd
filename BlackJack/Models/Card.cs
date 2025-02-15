namespace BlackJack.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Symbol { get; set; }

        public string Number { get; set; }

        public bool Flipped { get; set; }

        public User User { get; set; }
    }
}
