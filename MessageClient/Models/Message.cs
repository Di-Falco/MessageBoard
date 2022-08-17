using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Diagnostics;

namespace MessageClient.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public int TopicId { get; set; }
    public string Username { get; set; }
    public string MessageBody { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime PostDate { get; set; }
  
    public static List<Message> GetMessages()
    {
      var apiCallTask = MessageApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Message> messageList = JsonConvert.DeserializeObject<List<Message>>(jsonResponse.ToString());

      return messageList;
    }

    public static Message GetDetails(int id)
    {
      var apiCallTask = MessageApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Message message = JsonConvert.DeserializeObject<Message>(jsonResponse.ToString());

      return message;
    }

    public static async Task Post(Message message)
    {
      string jsonMessage = JsonConvert.SerializeObject(message);
      await Task.Run(() => MessageApiHelper.Post(jsonMessage));
    }

    public static async Task Put(Message message)
    {
      string jsonMessage = JsonConvert.SerializeObject(message);
      await Task.Run(() => MessageApiHelper.Put(message.MessageId, jsonMessage));
    }

    public static async Task Delete(int id)
    {
      await Task.Run(() => MessageApiHelper.Delete(id));
    }

  }
}
