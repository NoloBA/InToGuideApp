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

        #region user

        public User CreateNewUser(User user)
        {
            _inToGuideContext.Users.Add(user);
            _inToGuideContext.SaveChanges();

            return user;
        }
        
        
        public bool DoesUserExistById(int id) 
        {
            return _inToGuideContext.Users.Any(us => us.UserId == id);
        }

        public bool DoesUserExistByAccountType(bool accounttype)
        {
            return _inToGuideContext.Users.Any(us => us.AccountType == accounttype);
        }

        public bool DoesUserExistByEmailAddress(string email)
        {
            return _inToGuideContext.Users.Any(us => us.EmailAddress == email);
        }

        public List<User> GetAllUsers(bool fullfetch = true) 
        {
            if (fullfetch)
            {
                var users = _inToGuideContext.Users.Include(u => u.MatchId).ToList();
                return users;
            }
            else 
            {
                var users = _inToGuideContext.Users.ToList();
                return users;
            }
                
        }

        public User GetUserById(int id, bool fullfetch = true) 
        {
            if (fullfetch)
            { 
            var users = _inToGuideContext.Users.Where(x => x.UserId == id).Include(u => u.MatchId).FirstOrDefault();
                return users;
            }
            else 
            { 
            var users = _inToGuideContext.Users.Where(x => x.UserId == id).FirstOrDefault();
                return users;
            }
        }

        public User GetUserbyLastName(string surname, bool fullFatch = true) 
        {
        if(fullFatch)              
                {
                    var users = _inToGuideContext.Users.Where(x => x.LastName.Contains(surname)).Include(x => x.MatchId).FirstOrDefault();
                    return users;
                }
                else
                {
                    var users = _inToGuideContext.Users.Where(x => x.LastName.Contains(surname)).FirstOrDefault();
                    return users;

                }
        }

        public User GetUserByEmail(string email, bool fullFetch = true)
        {
            if (fullFetch)
            {
                var users = _inToGuideContext.Users.Where(x => x.EmailAddress == email).Include(x => x.MatchId).Include(x => x.MatchId).FirstOrDefault();
                return users;
            }
            else
            {
                var users = _inToGuideContext.Users.Where(x => x.EmailAddress == email).FirstOrDefault();
                return users;

            }
        }

        public User GetUserAccountType(bool accounttype,bool fullFetch = true)
        {
            if (fullFetch)
            { 
            var users = _inToGuideContext.Users.Where(x => x.AccountType == accounttype).Include(x => x.MatchId).FirstOrDefault();
                return users;
            }
            else 
            {
                var users = _inToGuideContext.Users.Where(x => x.AccountType == accounttype).FirstOrDefault();
                return users;  
            }
        }

        #endregion

        #region Chat

        /*public Chat CreateChat(Chat chat)
        {
            var chats = _inToGuideContext.Chats.Add(chat);
            var chats
        }*/

        #endregion


       
        public Certificate CreateNewCertificate(Certificate certificate)
        {
            _inToGuideContext.Certificates.Add(certificate);
            _inToGuideContext.SaveChanges();
            return certificate;
        }

        public HelpAndSupport CreateNewHelpAndSupport(HelpAndSupport helpAndSupport)
        {
            _inToGuideContext.HelpAndSupports.Add(helpAndSupport);  
            _inToGuideContext.SaveChanges();
            return helpAndSupport;
        }
        
        /*public MentorHistory CreateNewMentorHistory(MentorHistory mentorhistory)
        {
            
        }*/

        public Review CreateNewReview(Review review)
        {
            _inToGuideContext.Reviews.Add(review);
            _inToGuideContext.SaveChanges();
            return review;
        }

      

        public bool DoesHistoryIdExistUser(MentorHistory mentorhistory)
        {
            
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


        #region Authentication
        public bool PerfomAuthenticationCheck(string userName, string password) 
        {
            var users = _inToGuideContext.Authentications.Where(u => u.EmailAddress == userName && u.Password == password).FirstOrDefault();

            if (users != null)
            {
                return true;
            }
            return false;
        }
        #endregion
    }

}
