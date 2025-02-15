namespace BlackJack.Models
{
    public class Statistic
    {
        public int Id { get; set; }

        public double RoundMoney { get; set; }
        public bool Win { get; set; }

        public bool Lose { get; set; }

        public bool Tie { get; set; }

        public double PlacedBet { get; set; }

        public DateTime RoundDate { get; set; }

        public User User { get; set; }
    }
}
