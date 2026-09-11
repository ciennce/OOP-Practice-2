using OOP_Practice_2___Bibliothek.Model;

namespace OOP_Practice_2___Bibliothek.Library
{
    class Library
    {

        public Library()
        {
            
        }

        public bool Lend(Member member, Media media)
        {
            if(member._Type.Count < 3)
            {
                member._Type.Add(media);
                media.LendTo(member);
                return true;
            }else
            {
                return false;
            }
        }
    }
}
