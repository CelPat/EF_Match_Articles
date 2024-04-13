using ASWWW_lab2_gr4_nohttps.Models;

namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Lead { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreationDate { get; set; }

        // Klucz obcy autora
        public int AuthorId { get; set; } 

        // Artykuł może mieć jednego autora
        public virtual Author Author { get; set; } = null!;



        // Artykuł może mieć wiele komentarzy
        public virtual ICollection<Comment>? Comments { get; set; }



        // klucz obcy kategorii
        public int? CategoryId { get; set; }

        // Artykuł może mieć jedną kategorie
        public virtual Category? Category { get; set; } = null!;



        // Artykuł może mieć wiele Tagów
        public virtual ICollection<Tag>? Tags { get; set; }



        // Klucz obcy Meczu - może być nullem
        public int? MatchId { get; set; }

        // Atykuł może mieć zapisany mecz, ale może też go nie mieć (? - może być nullem)
        public virtual Match? Match {  get; set; }

        
    }
}
