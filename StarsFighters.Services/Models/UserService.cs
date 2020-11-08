using Microsoft.EntityFrameworkCore.Internal;
using StarsFighters.Data;
using StarsFighters.Data.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace StarsFighters.Services.Models
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext db;

        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void CreateUser(string name, string email, string password)
        {
            var newUser = new User
            {
                UserName = name,
                Email = email,
                PasswordHash = password
            };

            this.db.User.Add(newUser);
            this.db.SaveChanges();
        }

        public string GetUserId(string name, string password)
        {
            
            var userId = this.db.User.FirstOrDefault(x => x.UserName == name && x.PasswordHash == password);
            return userId?.Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return this.db.User.Any(x => x.Email == email);
        }

        public bool IsUserNameAvailable(string username)
        {
            return this.db.User.Any(x => x.UserName == username);
        }

    }
}
