using System;
using System.Linq;
using System.Threading.Tasks;
using FileData;
using DNP_AssignmentWebAPI.Models;
using DNP_AssignmentWebAPI.Data;

namespace DNP_AssignmentWebAPI.Data
{
    public class UserService : IUserCloudService     
    {
        private static FileContext _fileContext = new FileContext();
        
        public async Task<User> ValidateUserAsync(string UserName, string Password)
        {
            Console.WriteLine(UserName);
            Console.WriteLine(_fileContext.Users.Count);
            
            User first = _fileContext.Users.FirstOrDefault(user => user.UserName.Equals(UserName));
            
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(Password))
            {
                throw new Exception("Password incorrect, try again");
            }

            return first;        
        }
    }
}