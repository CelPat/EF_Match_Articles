namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        
        // Event Type może miec wiele Match Eventów
        public virtual ICollection<MatchEvent> MatchEvents { get; set; } =null!;

    }
}
