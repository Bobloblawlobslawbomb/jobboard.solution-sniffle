using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobOpeningController : Controller
  {
    [HttpGet("/display-form")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/display-job-opening")]
    public ActionResult Create(string formTitle, string formDescription, string contactName, string contactEmail, string contactPhoneNumber)
    {
      Contact formContactInfo = new Contact();
      formContactInfo.ContactInfo["name"] = contactName;
      formContactInfo.ContactInfo["email"] = contactEmail;
      formContactInfo.ContactInfo["phoneNumber"] = contactPhoneNumber;
      JobOpening inputJob = new JobOpening(formTitle, formDescription, formContactInfo);
      return RedirectToAction("Index");
    }

    [HttpGet("/display-job-opening")]
    public ActionResult Index()
    {
      List<JobOpening> allJobOpenings = JobOpening.GetAll();
      return View(allJobOpenings);
    }
  }
}