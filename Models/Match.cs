namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Stadium { get; set; } = null!;


        // Mecz może mieć wiele Artykułów
        public virtual ICollection<Article> Articles { get; set; } = null!;


        // Mecz może mieć wiele MatchEventów (chyba, że to Burnley)
        public virtual ICollection<MatchEvent> MatchEvents { get; set; }


        //Match posiada 2 drużyny - HomeTeam i AwayTeam
        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }


        public int AwayTeamId { get; set; }
        public virtual Team AwayTeam {  get; set; }

    }
}
