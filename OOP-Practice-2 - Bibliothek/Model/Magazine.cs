namespace OOP_Practice_2___Bibliothek.Model
{
    class Magazine : Media
    {
        private string IssueNumber { get; set; }

        public Magazine(int id, string title, string year, string issueNumber)
            : base(id, title, year)
        {
            IssueNumber = issueNumber;
        }
    }
}
