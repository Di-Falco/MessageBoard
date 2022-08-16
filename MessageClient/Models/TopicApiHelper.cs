using System.Threading.Tasks;
using RestSharp;

namespace MessageClient.Models
{
  class TopicApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"topics", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get (int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"topics/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newTopic)
    {
      RestClient client = new RestClient("http://Localhost:5002/api");
      RestRequest request = new RestRequest($"topics", Method.POST);
      request.AddHeader("Content-Type", "Application/json");
      request.AddJsonBody(newTopic);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newTopic)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"topics/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newTopic);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"topics/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }

  }
}