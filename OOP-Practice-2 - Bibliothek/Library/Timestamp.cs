namespace OOP_Practice_2___Bibliothek.Library
{
    class Timestamp
    {
        public DateTime GetTime()
        {
            DateTime datetime = DateTime.Now;
            var (day, hour, minute) = (datetime.Day, datetime.Hour, datetime.Minute);
            return datetime;
        }
    }
}
