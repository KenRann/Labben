using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Labben
{
    public class APIDataAccess
    {
        private readonly string _source;
        string? response;       


        public APIDataAccess()
        {

        }

        public async Task GetDataAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();

                Task<string> getData = client.GetStringAsync(_source);

                response = await getData;
            }
            catch (InvalidOperationException)
            { throw; }
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

        }

        public void ReadData()
        { 
            Person userData = JsonSerializer.Deserialize<Person>(response);
        }

        //public IQueryable<Person> GetUsers()
        //{

        //}
    }
}
