using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Labben
{
    public class APIDataAccess : IGetUsers
    {
        private readonly string _source;
        string? response;       


        public APIDataAccess()
        {

        }

        public async Task<string> GetDataAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();

                var retrievedData = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

                return retrievedData;

        }
            catch (InvalidOperationException)
            {
                Console.WriteLine("1");
                throw; }
            catch (HttpRequestException)
            {
                Console.WriteLine("2");
                throw; }
            catch (TaskCanceledException)
            {
                Console.WriteLine("3");
                throw; }           
        }

        public List<Person> DeserializeAPIData(string apiJsonData)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                { PropertyNameCaseInsensitive = true };

                var deserializedData = JsonSerializer.Deserialize<List<Person>>(apiJsonData, options);
                return deserializedData;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Deserialization error: {ex.Message}");
                throw;
            }
            //return JsonSerializer.Deserialize<List<Person>>(apiJsonData, options);
        }

        public async Task<IQueryable<Person>> GetUsersAsync()
        {
            //IQueryable<Person> userData = JsonSerializer.Deserialize<IQueryable<Person>>(response, options);
            //return userData;
            try
            {
                var json = await GetDataAsync();
                var users = DeserializeAPIData(json);
                return users.AsQueryable();
            }
            catch {
                Console.WriteLine("hej"); 
                throw; }
            //return DeserializeAPIData(GetDataAsync().Result).AsQueryable(); 
        }

        public IQueryable<Person> GetUsersSync()
        { 
            throw new NotImplementedException();
        }

        //public IQueryable<Person> GetUsers()
        //{

        //}
    }
}
