using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_Assignment.Models;
using Models;

namespace DNP_Assignment.Data
{
    public interface ICloudService
    {
        Task<IList<Adult>> getAdultsAsync();
        Task addAdultAsync(Adult adult);
        Task removeAdultAsync(int id);
       // Task updateFirstNameAsync(Adult adult, string firstName);

        Task updateAdult(Adult adult, string firstName, string lastName, string hairColor, string eyeColor, int age,
            float weight, int height, string sex);

        Task<User> validateUser(string Username, string password);
    }
}