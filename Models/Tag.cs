namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Tagi mogą mieć wiele artykułów
        public virtual ICollection<Article>? Articles { get; set; } = null!;
    }
}
