namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Kategoria może mieć wiele Artykułów
        public virtual ICollection<Article>? Articles { get; set; }
    }
}
