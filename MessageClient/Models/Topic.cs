using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageClient.Models
{
  public class Topic
  {
    public int TopicId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public HashSet<Message> Messages { get; set; }
  
    public static List<Topic> GetTopics()
    {
      var apiCallTask = TopicApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Topic> topicList = JsonConvert.DeserializeObject<List<Topic>>(jsonResponse.ToString());

      return topicList;
    }

    public static Topic GetDetails(int id)
    {
      var apiCallTask = TopicApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Topic topic = JsonConvert.DeserializeObject<Topic>(jsonResponse.ToString());

      return topic;
    }

    public static void Post(Topic topic)
    {
      string jsonTopic = JsonConvert.SerializeObject(topic);
      var apiCallTask = TopicApiHelper.Post(jsonTopic);
    }

    public static void Put(Topic topic)
    {
      string jsonTopic = JsonConvert.SerializeObject(topic);
      var apiCallTask = TopicApiHelper.Put(topic.TopicId, jsonTopic);
    }

    public static void Delete(int id)
    {
      var apiCallTask = TopicApiHelper.Delete(id);
    }

  }
}
