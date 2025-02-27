# TechJobPortal - README

## Project Overview

**TechJobPortal** is an ASP.NET Core MVC application designed to manage and display job listings. The application allows users to view a list of available jobs, read details of specific job postings, and navigate through the website using a responsive design.

---

## Features

1. **Job Listings Page:** Displays a list of job postings with titles, companies, and locations.
2. **Job Details Page:** Allows users to view detailed information about a selected job.
3. **Navigation Bar:** Provides easy navigation to job listings.
4. **Job Posting Date:** Displays the formatted posting date for each job listing.
5. **Responsive Design:** Optimized for mobile and desktop screens using Bootstrap.
6. **Partial Views:** Reusable layout for header and footer.

---

## Project Setup

### Prerequisites

Before running the project, make sure you have the following installed:

- **.NET SDK 6.0 or higher** (download from [dotnet.microsoft.com](https://dotnet.microsoft.com/download))
- **Visual Studio 2022 or Visual Studio Code** (optional, but recommended for development)

### Clone the Repository

To set up the project locally, clone the repository using the following command:

```bash
git clone https://github.com/yourusername/TechJobPortal.git
cd TechJobPortal
```

### Restore NuGet Packages

Run the following command to restore the project's NuGet packages:

```bash
dotnet restore
```

### Run the Application

To run the application, use the following command:

```bash
dotnet run
```

Once the project is running, you can access the application by navigating to `https://localhost:5001` in your browser.

---

## Structure of the Application

### 1. **Model: JobListing**

This model represents a job listing with the following properties:

- **Id** (integer): The unique identifier for the job listing.
- **Title** (string): The title of the job.
- **CompanyName** (string): The company posting the job.
- **Location** (string): The job's location.
- **JobType** (enum): The type of job (Full-time, Part-time, Remote, Contract).
- **PostedDate** (DateTime): The date the job was posted.

### 2. **Controller: JobController**

The `JobController` contains two actions:

- **Index**: Displays a list of job listings.
- **Details**: Displays details for a selected job listing.

### 3. **Views:**

- **Index.cshtml**: Displays a list of job listings.
- **Details.cshtml**: Displays detailed information about a selected job.
- **_Header.cshtml** (Partial View): Contains the header layout used across multiple views.
- **_Footer.cshtml** (Partial View): Contains the footer layout used across multiple views.

### 4. **Bootstrap Integration**

The application utilizes **Bootstrap** for styling and responsive design. The navigation bar is implemented using Bootstrap classes for mobile-friendly layout.

---

## How to Use

### Navigation Bar
- The navigation bar appears at the top of each page and includes links to view job listings and other sections of the site.

### Job Listings Page
- The main job listings page (`Index.cshtml`) displays a list of jobs.
- Clicking on a job title will redirect the user to the details page (`Details.cshtml`).

### Job Details Page
- The details page will display information about a specific job, including the company name, job type, location, and the formatted posting date (e.g., "Posted on: Jan 25, 2025").


