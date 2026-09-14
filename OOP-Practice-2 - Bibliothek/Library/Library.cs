using OOP_Practice_2___Bibliothek.Model;

namespace OOP_Practice_2___Bibliothek.Library 
{
    class Library
    {

        public Library()
        {
            
        }

        private readonly List<Media> _mediaStorage = new();
        private readonly List<Member> _members = new();


        public LendResult Lend(int memberId, int mediaId)
        {
            
            var member = _members.FirstOrDefault(m => m.MemberId == memberId);
            if (member == null)
            {
                return LendResult.
            }
            else
            {
                var media = _mediaStorage.FirstOrDefault(i => i.Id == mediaId);
                if (media == null)
                {
                    return LendResult.
                }
                else
                {
                    if (media.IsAvailable)
                    {
                        media.LendTo(member);
                        return LendResult.
                    }
                    else
                    {
                        return 
                    }

                }
            }    
            
        }


    }
}
