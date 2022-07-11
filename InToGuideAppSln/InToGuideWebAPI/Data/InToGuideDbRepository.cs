using InToGuideWebAPI.Models;
using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Enum;
using Microsoft.EntityFrameworkCore;



namespace InToGuideWebAPI.Data
{
    public class InToGuideDbRepository: IInToGuideDbRepository
    {
        private InToGuideContext _inToGuideContext;

        public InToGuideDbRepository(InToGuideContext inToGuideContext)
        {
            _inToGuideContext = inToGuideContext;
        }

        #region User

        public User CreateNewUser(User user)
        {
            _inToGuideContext.Users.Add(user);
            _inToGuide.SaveChanges();

            return user;
        }

        #endregion

        #region Authentication

        #endregion


        #region Match

        #endregion

        #region Chat

        #endregion

        #region Certificate
        #endregion

        #region HelpAndSupport
        #endregion

        #region MentorHistory
        #endregion

        #region Review
        #endregion 



    }

}
