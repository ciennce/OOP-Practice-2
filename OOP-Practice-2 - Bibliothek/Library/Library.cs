using OOP_Practice_2___Bibliothek.Model;

namespace OOP_Practice_2___Bibliothek.Library 
{
    class Library
    {

        public Library()
        {
            
        }

        public List<Media> MediaStorage { get; set; }

        public bool Lend(Member member, Media media)
        {
            if(member.Type.Count < 3)
            {
                if (media.IsAvailable)
                {
                    member.Type.Add(media);
                    media.LendTo(member);
                    return true;
                }
                return false;
            }else
            {
                return false;
            }
        }

        public void AddItem(Media media)
        {
            MediaStorage.Add(media);
        }
    }
}
