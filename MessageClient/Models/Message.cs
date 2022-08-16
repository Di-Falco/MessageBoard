using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
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

    public static void Post(Message message)
    {
      string jsonMessage = JsonConvert.SerializeObject(message);
      var apiCallTask = MessageApiHelper.Post(jsonMessage);
    }

    public static void Put(Message message)
    {
      string jsonMessage = JsonConvert.SerializeObject(message);
      var apiCallTask = MessageApiHelper.Put(message.MessageId, jsonMessage);
    }

    public static void Delete(int id)
    {
      var apiCallTask = MessageApiHelper.Delete(id);
    }

  }
}
