namespace OOP_Practice_2___Bibliothek.Model
{
    class Book : Media
    {
        private int PageCount { get; set; }

        private string Author { get; set; }

        public Book(int id, string title, string year, int pageCount, string author)
            : base(id, title, year)
        {
            PageCount = pageCount;
            Author = author;
        }
    }
}
