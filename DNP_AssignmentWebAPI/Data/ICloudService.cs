using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_AssignmentWebAPI.Models;

namespace DNP_AssignmentWebAPI.Data
{
    public interface ICloudService
    {
        Task<IList<Adult>> getAdultsAsync();
        Task<Adult> addAdultAsync(Adult adult);
        Task removeAdultAsync(int id);
        //Task<Adult> updateFirstNameAsync(int Id, string firstname);

        //Task<Adult> updateAdult(int Id);

        Task<Adult> updateAdult(int Id, string firstName, string lastName, string hairColor, string eyeColor, int age,
            float weight, int height, string sex);

        /*
        Task updateLastNameAsync(Adult adult, string lastName);
        Task updateHairColorAsync(Adult adult, string hairColor);
        Task updateEyeColorAsync(Adult adult, string eyeColor);
        Task updateAgeAsync(Adult adult, int age);
        Task updateWeightAsync(Adult adult, float weight);
        Task updateHeightAsync(Adult adult, int Height);
        Task updateSexAsync(Adult adult, string sex);
        */
    }
}