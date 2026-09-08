namespace OOP_Practice_2___Bibliothek.Model
{
    class Dvd
    {
        private string Director { get; set; }
        private string Duration { get; set; }

        public Dvd(string director, string duration)
        {
            Director = director;
            Duration = duration;
        }
    }
}
