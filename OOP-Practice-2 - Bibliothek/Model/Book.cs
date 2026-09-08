namespace OOP_Practice_2___Bibliothek.Model
{
    class Book
    {
        private int PageCount { get; set; }

        private string Author { get; set; }

        public Book(int pageCount, string author)
        {
            PageCount = pageCount;
            Author = author;
        }
    }
}
