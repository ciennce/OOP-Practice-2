namespace OOP_Practice_2___Bibliothek.Model
{
    class Member
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public Member(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}

