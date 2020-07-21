using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobOpeningsController: Controller
  {
    [HttpPost("/jobs")]
    public ActionResult Index(string title, string description, string contactInfoName, string contactInfoEmail, string contactInfoPhone)
    {
      JobOpening newJobOpening = new JobOpening(title, description, contactInfoName, contactInfoEmail, contactInfoPhone);
      return View();
    }
  }
}