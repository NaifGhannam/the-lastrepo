using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TechJobPortal.Models;

namespace TechJobPortal.Controllers
{
    public class JobController : Controller
    {

        private static List<JobListing> jobListings = new List<JobListing>
        {
            new JobListing { Id = 1, Title = "Software Engineer", CompanyName = "TechCorp", Location = "Riyadh", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-5) },
            new JobListing { Id = 2, Title = "Data Analyst", CompanyName = "DataWorks", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.Now.AddDays(-10) },
            new JobListing { Id = 3, Title = "Web Developer", CompanyName = "WebStudio", Location = "Dammam", JobType = JobType.Contract, PostedDate = DateTime.Now.AddDays(-3) },
            new JobListing { Id = 4, Title = "System Administrator", CompanyName = "NetSecure", Location = "Khobar", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-7) },
            new JobListing { Id = 5, Title = "UI/UX Designer", CompanyName = "CreativeLabs", Location = "Madinah", JobType = JobType.PartTime, PostedDate = DateTime.Now.AddDays(-2) }
        };

        public IActionResult Index()
        {
            return View(jobListings);
        }

        public IActionResult Details(int id)
        {
            var job = jobListings.Find(j => j.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

    }
}
