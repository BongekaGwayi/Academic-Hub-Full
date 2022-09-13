namespace Academic_Hub.Models
{
    public class UserManager
    {
        private static UserManager uniqueInstance;
        private static User CurrentUser;
        private UserManager() { }
        public static UserManager GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new UserManager();
            }
            return uniqueInstance;
        }
        public static bool UserLogged()
        {
            if (CurrentUser == null)
                return false;
            return true;
        }
        public static void LogUser(User user)
        {
            CurrentUser = user;
        }
        public static User GetLoggedUser()
        {
            if (CurrentUser == null)
            {
                return new User();
            }
            return CurrentUser;
        }
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
