namespace AnimalRegister.MVVM.Model
{
    public class AuthorizedUser
    {
        public User user { get; set; }

        public static AuthorizedUser authorizedUser;

        public AuthorizedUser(User user)
        {
            this.user = user;
            authorizedUser = this;
        }
    }
}