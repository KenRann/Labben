using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Labben
{
    public class APIDataAccess
    {
        private readonly string _source = "https://jsonplaceholder.typicode.com/users";
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
            { throw; }
            catch (TaskCanceledException) 
            { throw; }

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
