using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using MessageClient.Models;
using MessageClient.Migrations;

namespace MessageClient.Controllers
{
  [Authorize]
  public class TopicsController : Controller
  {
    [AllowAnonymous]
    public IActionResult Index()
    {
      ViewBag.Title = "Topics";
      ViewBag.Subtitle = "All Topics";
      var allTopics = Topic.GetTopics();
      return View(allTopics);
    }

    public ActionResult Details(int id)
    {
      ViewBag.Title = "Topics";
      ViewBag.Subtitle = "Posts in Topic";
      return View(Topic.GetDetails(id));
    }
  }
}