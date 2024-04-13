namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class MatchPlayer
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Klucz obcy pozycji
        public int PositionId { get; set; }
        // Grający Zawodnik może mieć 1 pozycję
        public virtual Position Position { get; set; } = null!;

        // Match Player może mieć wiele Match Eventów
        public virtual ICollection<MatchEvent> MatchEvents { get; set; } = null!;


        // Klucz obcy Zawodnika
        public int PlayerId { get; set; }

        // Match Player jest powiązany z Zawodnikiem
        public virtual Player Player { get; set; } = null!;
    }
}
