namespace FamilyBlazorWebApp.Impl
{
    public interface IUserService
    {
        void CreateUser(User user);
        User ValidateUser(string userName, string password);
    }
}