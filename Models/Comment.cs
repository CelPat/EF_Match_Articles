namespace ASWWW_lab2_gr4_nohttps.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;

        // Klucz obcy Artykułu
        public int ArticleId { get; set; }

        // Dany Komentarz może być tylko do jednego Artykułu
        public virtual Article Article { get; set; }
    }
}
