using OOP_Practice_2___Bibliothek.Model;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Practice_2___Bibliothek.Library 
{
    class Library
    {
        private readonly List<Media> _mediaStorage = new();
        private readonly List<Member> _members = new();


        public LendResult Lend(int memberId, int mediaId)
        {
            
            var member = _members.FirstOrDefault(m => m.MemberId == memberId);
            if (member == null) return LendResult.MemberNotFound;

            var media = _mediaStorage.FirstOrDefault(i => i.Id == mediaId);
            if (media == null) return LendResult.MediaNotFound;

            if (!media.IsAvailable) return LendResult.NotAvailable;
            if (member.Type.Count >= 3) return LendResult.LimitReached;
            if(!media.IsLendable) return LendResult.NotLendable;

            media.LendTo(member);
            member.Type.Add(media);
            return LendResult.Ok;
        }

        public LendResult ReturnMedia(int memberId, int mediaId)
        {
            var member = _members.FirstOrDefault(m => m.MemberId == memberId);
            if (member == null) return LendResult.MemberNotFound;

            var media = member.Type.FirstOrDefault(i =>i.Id == mediaId);
            if(media == null) return LendResult.MediaNotFound;

        }
    }  
}
