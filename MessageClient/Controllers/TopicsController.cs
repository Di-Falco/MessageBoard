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
  public class TopicsController : Controller
  {
    public IActionResult Index()
    {
      var allTopics = Topic.GetTopics();
      return View(allTopics);
    }

    public ActionResult Details(int id)
    {
      return View(Topic.GetDetails(id));
    }
  }
}