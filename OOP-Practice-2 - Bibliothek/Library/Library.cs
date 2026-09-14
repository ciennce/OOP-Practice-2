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
                return LendResult.MemberNotFound;
            }
            else
            {
                if (member.Type.Count >= 3)
                {
                    return LendResult.LimitReached;
                }
                else
                {
                    var media = _mediaStorage.FirstOrDefault(i => i.Id == mediaId);
                    if (!media.IsAvailable || media == null)
                    {
                        return LendResult.NotAvailable;
                    }
                    else
                    {
                        if (!media.IsLendable || media == null)
                        {
                            return LendResult.NotLendable;
                        }
                        else
                        {
                            member.Type.Add(media);
                            return LendResult.Ok;

                        }
                    }
                }
            }







            //else
            //{
            //    var media = _mediaStorage.FirstOrDefault(i => i.Id == mediaId);
            //    if (media == null)
            //    {
            //        return LendResult.
            //    }
            //    else
            //    {
            //        if (media.IsAvailable)
            //        {
            //            media.LendTo(member);
            //            return LendResult.
            //        }
            //        else
            //        {
            //            return 
            //        }
            //
            //    }
            //}    
            
        }


    }
}
