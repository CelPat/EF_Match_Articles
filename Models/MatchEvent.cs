namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int Minute { get; set; }


        // Klucz obcy meczu
        public int MatchId { get; set; }
        // Match Event musi mieć jeden mecz
        public virtual Match Match { get; set; } = null!;


        //klucz obcy Event Type'u
        public int EventTypeId { get; set; }
        // Match Event może mieć jeden Event Type
        public virtual EventType EventType { get; set; } = null!;

        // Klucz obcy MatchPlayer'a - może być nullem
        public int? MatchPlayerId { get; set; }

        // Event może odnosić się do MatchPlayera, ale nie musi
        public virtual MatchPlayer MatchPlayer { get; set; }
    }
}
