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
                Username = name,
                Email = email,
                Password = ComputeHash(password)
            };

            this.db.User.Add(newUser);
            this.db.SaveChanges();
        }

        public string GetUserId(string name, string password)
        {
            var passwordHashed = ComputeHash(password);
            var userId = this.db.User.FirstOrDefault(x => x.Username == name && x.Password == passwordHashed);
            return userId?.Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return this.db.User.Any(x => x.Email == email);
        }

        public bool IsUserNameAvailable(string username)
        {
            return this.db.User.Any(x => x.Username == username);
        }

        private static string ComputeHash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using var hash = SHA512.Create();
            var hashedInputBytes = hash.ComputeHash(bytes);
            // Convert to text
            // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
            var hashedInputStringBuilder = new StringBuilder(128);
            foreach (var b in hashedInputBytes)
                hashedInputStringBuilder.Append(b.ToString("X2"));
            return hashedInputStringBuilder.ToString();
        }
    }
}
