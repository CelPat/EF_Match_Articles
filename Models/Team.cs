namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public DateTime FoundingDate { get; set; }


        // Klucz obcy Ligi
        public int LeagueId { get; set; }
        // Drużyna może grać w jednej lidze
        public virtual League League { get; set; } = null!;

        // Drużyna może mieć wielu Zawodników
        public virtual ICollection<Player> Players { get; set; } = null!;

        // Klucz obcy meczu
        public int MatchId { get; set; }
        
        //Team może mieć dużo meczów domowych HomeMatch
        public virtual ICollection<Match> HomeMatches { get; set; } = null!;

        //Team może mieć dużo meczów wyajzdowych AwayMatch
        public virtual ICollection<Match> AwayMatches { get; set; } = null!;


    }
}
