namespace StarsFighters.Services.Models
{
    public interface IUserService
    {
        void CreateUser(string name, string email, string password);

        bool IsUserNameAvailable(string username);

        bool IsEmailAvailable(string email);

        string GetUserId(string name, string password);


    }
}
