using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DNP_Assignment.Data;
using DNP_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DNP_Assignment.Data
{
    public class CloudService : ICloudService
    {
        private string uri = "https://localhost:5002";
        private readonly HttpClient client;
        
        public CloudService() {
            client = new HttpClient();
        }
        
        /*Adults*/
        public async Task<IList<Adult>> getAdultsAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }
        
        public async Task addAdultAsync(Adult adult)
        {
            Console.WriteLine(adult.JobTitle);
            string todoAsJson = JsonSerializer.Serialize(adult);
            
            HttpContent content = new StringContent(todoAsJson,
                Encoding.UTF8,
                "application/json");
            
            HttpResponseMessage responseMessage = await client.PostAsync(uri + "/Adults", content);
            Console.WriteLine(responseMessage.ToString());
        }

        public async Task removeAdultAsync(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync($"{uri}/Adults/{id}");
            Console.WriteLine(responseMessage.ToString());
        }
        
        public async Task updateAdult(Adult adult, string firstName, string lastName, string hairColor, string eyeColor, int age, float weight, int height, string sex)
        {
            int id = adult.Id;
            adult.FirstName = firstName;
            adult.LastName = lastName;
            adult.HairColor = hairColor;
            adult.EyeColor = eyeColor;
            adult.Age = age;
            adult.Weight = weight;
            adult.Height = height;
            adult.Sex = sex;
            
            string todoAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(todoAsJson,
                Encoding.UTF8,
                "application/json");
            
            await client.PatchAsync($"{uri}/Adults/{id}", content);
        }

        // Users
        public async Task<User> validateUser(string Username, string Password)
        {
            Console.WriteLine("CloutService test " + Username + " " + Password);
            Task<string> stringAsync = client.GetStringAsync(uri + $"/Users?UserName={Username}&Password={Password}");
            string message = await stringAsync;
            User result = JsonSerializer.Deserialize<User>(message);
            return result;         
        }
        
      
    }
}