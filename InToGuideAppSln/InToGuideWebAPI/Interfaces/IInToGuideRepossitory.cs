
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Interfaces
{
    public interface IInToGuideRepossitory
    {
        Certificate CreateNewCertificate(Certificate certificate);
        User CreateNewUser(User user);
        Chat CreateChat(Chat chat);
        bool DoesThreadIdExistByUser(string threadId);
        bool DoesMessageExistByUser(string message);
        List<Chat> GetChatList(bool fullFetch = true);

        HelpAndSupport CreateNewHelpAndSupport(HelpAndSupport helpAndSupport);
        bool DoesEmailAddresExistByUser(string email);
        List<HelpAndSupport> GetHelpAndSupports(bool fullFetch = true);
        MentorHistory CreateNewMentorHistory(MentorHistory mentorhistory);
        IActionResult CreateNewMatch();
        bool DoesHistoryIdExistUser(MentorHistory mentorhistory);
        Review  CreateNewReview(Review review);




    }
}
