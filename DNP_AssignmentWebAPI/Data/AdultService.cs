using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DNP_AssignmentWebAPI.Models;
using DNP_AssignmentWebAPI.Data;
using DNP_AssignmentWebAPI.Models;
using FileData;

namespace DNP_AssignmentWebAPI.Data
{
    public class AdultService : ICloudService
    {
        private FileContext _fileContext = new FileContext();

        
        public async Task<IList<Adult>> getAdultsAsync()
        {
            return _fileContext.Adults;
        }
        // TODO add users?
        
        public int addId()
        {
            int j = 0;
            for (int i = 0; i < _fileContext.Adults.Count; i++)
            {
                if (_fileContext.Adults[i].Id != i)
                {
                    return i;
                }
            }

            return _fileContext.Adults.Count;
        }


        public async Task<Adult> addAdultAsync(Adult adult)
        {
            int id = addId();
            adult.Id = id;
            _fileContext.Adults.Insert(id,adult);
            _fileContext.SaveChanges();
            return adult;
        }

        public async Task removeAdultAsync(int id)
        {
            Adult adultToBeRemoved = _fileContext.Adults.First(i => i.Id == id);

            _fileContext.Adults.Remove(adultToBeRemoved);
            _fileContext.SaveChanges();        
        }
        
     /*   public async Task<Adult> updateFirstNameAsync(int Id, string firstName)
        {
            Adult adultToBePatched = _fileContext.Adults.First(i => i.Id == Id);

            adultToBePatched.FirstName = firstName;
            Console.WriteLine(firstName + " THe first name");
            _fileContext.SaveChanges();
            return adultToBePatched;
        }
*/
        /*public async Task<Adult> updateAdult(int Id)
        {
            Adult adultToBePatched = _fileContext.Adults.First(i => i.Id == Id);

            _fileContext.SaveChanges();
            return adultToBePatched ;
        }
*/
        public async Task<Adult> updateAdult(int Id, string firstName, string lastName, string hairColor, string eyeColor, int age, float weight, int height, string sex)
        {
            Adult adultToBePatched = _fileContext.Adults.First(i => i.Id == Id);
            
            adultToBePatched.FirstName = firstName;
            adultToBePatched.LastName = lastName;
            adultToBePatched.HairColor = hairColor;
            adultToBePatched.EyeColor = eyeColor;
            adultToBePatched.Age = age;
            adultToBePatched.Weight = weight;
            adultToBePatched.Height = height;
            adultToBePatched.Sex = sex;
            
            _fileContext.SaveChanges();
            return adultToBePatched;
        }
    }
}