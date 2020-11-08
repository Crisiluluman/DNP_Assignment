using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_AssignmentWebAPI.Models;

namespace DNP_AssignmentWebAPI.Data
{
    public interface IUserCloudService
    {
        Task<User> ValidateUserAsync(string UserName, string Password);

    }
}