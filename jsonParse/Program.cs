using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //string json = @"{
            //                  ""1""{
            //                 ""email"":""VN@atos.net""
            //                 ""createdDate"": ""2017 / 10 / 3 08:57:34"",
            //                 ""name"":""Valeriya Nikokaevna""
            //               },
            //                  ""2""{
            //                 ""email"":""VN@atos.net""
            //                 ""createdDate"":""2017 / 10 / 3 08:57:34"",
            //                 ""name"":""Valeriya Nikokaevna""
            //               }}";

            //string json2 = @"{
            //                ""response"":{
            //                ""count"":198,
            //                 ""items"":[
            //                    {
            //                ""email"":""VN@atos.net""
            //                 ""createdDate"":""2017 / 10 / 3 08:57:34"",
            //                 ""name"":""Valeriya Nikokaevna""
            //                         },
            //                    {
            //                    ""email"":""VN@atos.net""
            //                 ""createdDate"":""2017 / 10 / 3 08:57:34"",
            //                 ""name"":""Valeriya Nikokaevna""
            //                      }
            //                      ]
            //                      }
            //                    }";

      
            User user = new User
            {
                Email = "abv.@mail.ru",
                CreatedDate = DateTime.Now,
                Name = "Ivan"

            };

            string jsonser = JsonConvert.SerializeObject(users, Formatting.Indented);

            List<User> jsonusers = JsonConvert.DeserializeObject<List<User>>(jsonser);

            foreach (var item in jsonusers)
            {
                Console.WriteLine(item.Email);
            }


            public List<User> AddUsers(user)
            {
                List<User> users = new List<User>();

                return users
            }
        }
    }
    public class User
{
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "createdDate")]
        public DateTime CreatedDate { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
}

}
