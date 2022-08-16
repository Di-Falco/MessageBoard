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
    public async Task<ActionResult> Create(int topicId, string username, string messageBody)
    {
      Message message = new Message { TopicId = topicId, Username = username, PostDate = DateTime.Now, MessageBody = messageBody };
      await Task.Run(() => Message.Post(message));
      return Redirect(Request.Headers["Referer"].ToString());
    }

    public ActionResult Details(int id)
    {
      return View(Message.GetDetails(id));
    }
  }
}