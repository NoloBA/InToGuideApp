using InToGuideWebAPI.Controllers;
using InToGuideWebAPI.Enum;
using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InToGuideWebAPI.Data
{
    public class InToGuideDbRepository: IInToGuideRepossitory
    {
        private readonly InToGuideContext _inToGuideContext;

        public InToGuideDbRepository(InToGuideContext inToGuideContext)
        {
            _inToGuideContext = inToGuideContext;
        }

        public Chat CreateChat(Chat chat)
        {
            throw new NotImplementedException();
        }

        public Certificate CreateNewCertificate(Certificate certificate)
        {
            throw new NotImplementedException();
        }

        public HelpAndSupport CreateNewHelpAndSupport(HelpAndSupport helpAndSupport)
        {
            throw new NotImplementedException();
        }

        public IActionResult CreateNewMatch()
        {
            throw new NotImplementedException();
        }

        public Match CreateNewMatch(Match match)
        {
            throw new NotImplementedException();
        }

        public MentorHistory CreateNewMentorHistory(MentorHistory mentorhistory)
        {
            throw new NotImplementedException();
        }

        public Review CreateNewReview(Review review)
        {
            throw new NotImplementedException();
        }

        public User CreateNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<object?> CreateNewUser()
        {
            throw new NotImplementedException();
        }

        public bool DoesEmailAddresExistByUser(string email)
        {
            throw new NotImplementedException();
        }

        public bool DoesHistoryIdExistUser(MentorHistory mentorhistory)
        {
            throw new NotImplementedException();
        }

        public bool DoesMessageExistByUser(string message)
        {
            throw new NotImplementedException();
        }

        public bool DoesThreadIdExistByUser(string threadId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Match> GetAllMatches()
        {
            throw new NotImplementedException();
        }

        public List<Match> GetAllMatches(int MatchId, bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllReviews(bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public Chat GetChat(string chatId)
        {
            throw new NotImplementedException();
        }

        public List<Chat> GetChatList(bool 
            fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public List<Chat> GetChatList(int ChatId, bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chat> GetChatList()
        {
            throw new NotImplementedException();
        }

        public List<HelpAndSupport> GetHelpAndSupports(bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public MentorHistory GetMentorHistory(int HistorId, bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public List<MentorHistory> GetMentorHistorys(bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserId(int UserId, bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public object? PerformAuthenticationCheck()
        {
            throw new NotImplementedException();
        }

        public object? PerformAuthenticationCheck(object userName, object pin)
        {
            throw new NotImplementedException();
        }

        public bool PerformAuthenticationCheck(string userName, string pin)
        {
            throw new NotImplementedException();
        }
    }

}
