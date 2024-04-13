namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        // Autor może mieć wiele artykułów
        public virtual ICollection<Article>? Articles { get; set; }
    }
}
