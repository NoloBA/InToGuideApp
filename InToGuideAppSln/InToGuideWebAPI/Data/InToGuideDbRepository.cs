using InToGuideWebAPI.Controllers;
using InToGuideWebAPI.Enum;
using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InToGuideWebAPI.Data
{
    public class InToGuideDbRepository: IInToGuideRepossitory
    {
        private InToGuideContext _inToGuideContext;

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

        public List<Chat> GetChatList(bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public List<HelpAndSupport> GetHelpAndSupports(bool fullFetch = true)
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
