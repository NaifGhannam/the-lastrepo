using System;

namespace TechJobPortal.Models
{
    public enum JobType
    {
        FullTime,
        PartTime,
        Remote,
        Contract
    }

    public class JobListing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public JobType JobType { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
