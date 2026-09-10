namespace OOP_Practice_2___Bibliothek.Model
{
    class Member
    {
        public string Name { get; set; }

        public int MemberId { get; set; }

        public Member(string name, int memberId)
        {
            Name = name;
            MemberId = memberId;
        }

        public List<Media> _type { get; } = new List<Media>();

    }
}

