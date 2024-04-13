namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }



        // Pozycja może mieć wielu Zawodników
        public virtual ICollection<Player> Players { get; set; } = null!;

        //Pozycja może mieć wielu aktualnie grających zawodników
        public virtual ICollection<MatchPlayer> MatchPlayers { get; set; } = null!;

    }
}
