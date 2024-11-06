using Labben;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Labben
{
    public class APIDataAccess : IGetUsers
    {
        private readonly string _dataSource = "https://jsonplaceholder.typicode.com/users";

        public APIDataAccess()
        { }

        public async Task<string> GetDataAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();

                var getData = await client.GetStringAsync(_dataSource);

                return getData;
            }
            catch (InvalidOperationException)
            { throw; }
            catch (HttpRequestException)
            { throw; }
            catch (TaskCanceledException)
            { throw; }
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
        }

        public async Task<IQueryable<Person>> GetUsersAsync()
        {
            try
            {
                var json = await GetDataAsync();
                var users = DeserializeAPIData(json);
                return users.AsQueryable();
            }
            catch
            {
                throw;
            }
        }

        public IQueryable<Person> GetUsersSync()
        {
            throw new NotImplementedException();
        }
    }  
}