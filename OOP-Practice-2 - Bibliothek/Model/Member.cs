namespace OOP_Practice_2___Bibliothek.Model
{
    class Member
    {
        public string Name { get; set; }

        public int MemberId { get; set; }

        public List<Media> _Type { get; set; } = new List<Media>();

        public Member(string name, int memberId, List<Media> _type)
        {
            Name = name;
            MemberId = memberId;
            _Type = _type;
        }

    }
}

