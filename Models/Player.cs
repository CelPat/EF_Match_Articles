namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime BirthDate { get; set; }


        // Klucz obcy drużyny
        public int TeamId { get; set; }

        // Piłkarz może grać w 1 drużynie
        public virtual Team Team { get; set; } = null!;

        // Zawodnik może wiele razy być grającym zawodnikiem
        public virtual ICollection<MatchPlayer> MatchPlayers { get; set; } = null!;

        // Zawodnik może grać na wielu pozycjach
        public virtual ICollection<Position> Positions { get; set; } = null!;
    }
}
