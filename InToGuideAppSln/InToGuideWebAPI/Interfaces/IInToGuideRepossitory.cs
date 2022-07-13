
using InToGuideWebAPI.Controllers;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Interfaces
{
    public interface IInToGuideRepossitory
    {
        Certificate CreateNewCertificate(Certificate certificate);
        User CreateNewUser(User user);
        User GetUserByUserId(int UserId, bool fullFetch = true);
        Chat CreateChat(Chat chat);
        bool DoesMessageExistByUser(string message);
        List<Chat> GetChatList(int ChatId,bool fullFetch = true);
        Chat GetChat(string chatId);

        HelpAndSupport CreateNewHelpAndSupport(HelpAndSupport helpAndSupport);
        bool DoesEmailAddresExistByUser(string email);
        List<HelpAndSupport> GetHelpAndSupports(bool fullFetch = true);
        IActionResult CreateNewMatch();
        MentorHistory CreateNewMentorHistory(MentorHistory mentorhistory);
        IEnumerable<Match> GetAllMatches();
        MentorHistory GetMentorHistory(int HistorId, bool fullFetch = true);//!!
        List<MentorHistory> GetMentorHistorys(bool fullFetch = true);


        bool DoesHistoryIdExistUser(MentorHistory mentorhistory);
        Review CreateNewReview(Review review);
        List<Review> GetAllReviews(bool fullFetch = true);
        Task<object?> CreateNewUser();
        bool PerformAuthenticationCheck(string userName, string password);
        IEnumerable<Chat> GetChatList();
        Match CreateNewMatch(Match match);
        List<Match> GetAllMatches(int MatchId,bool fullFetch = true);
    }
}
