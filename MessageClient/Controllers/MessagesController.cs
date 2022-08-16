using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MessageClient.Models;

namespace MessageClient.Controllers
{
  public class MessagesController : Controller
  {
    public IActionResult Index()
    {
      var allMessages = Message.GetMessages();
      return View(allMessages);
    }

    [HttpPost]
    public ActionResult Create(int topicId, string username, string messageBody)
    {
      Message message = new Message { TopicId = topicId, Username = username, PostDate = DateTime.Now, MessageBody = messageBody };
      Message.Post(message);
      return RedirectToAction("Details", "Topics", new { id = topicId });
    }

    public ActionResult Details(int id)
    {
      return View(Message.GetDetails(id));
    }
  }
}