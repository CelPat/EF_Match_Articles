namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int Level { get; set; }

        
        // Liga ma wiele drużyn
        public virtual ICollection<Team> Teams { get; set; }
    }
}
