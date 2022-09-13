using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;

namespace Academic_Hub.Areas.Parent.Models
{
    public class UserLogger
    {
        private static UserLogger _uniqueInstance;
        private static ParentUser CurrentUser;
        private UserLogger() { }
        public static UserLogger GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new UserLogger();
            }
            return _uniqueInstance;
        }
        public static bool ParentLogged()
        {
            if (CurrentUser == null)
                return false;
            return true;
        }
        public static void LogParent(ParentUser user)
        {
            CurrentUser = user;
        }
        public static ParentUser GetLoggedParent()
        {
            if( CurrentUser == null )
                return new ParentUser();
            return CurrentUser;
        }
        public static void Logout()
        {
            UserManager.Logout();
            CurrentUser = null;
        }
    }
}
