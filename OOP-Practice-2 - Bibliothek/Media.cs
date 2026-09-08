namespace OOP_Practice_2___Bibliothek
{
    abstract class Media
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }

        public Member? BorrowedBy { get; private set; }
        protected Media(int id, string title, string year)
        {
            Id = id;
            Title = title;
            Year = year;
        }

        public bool IsAvailable => BorrowedBy == null;
        public virtual bool IsLendable => true;

        public void LendTo(Member member) 
        { 
            BorrowedBy = member;
        }

    }
}
