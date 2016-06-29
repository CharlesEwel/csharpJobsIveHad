using System.Collections.Generic;
using Nancy;
using myJob.Objects;

namespace myJobs
{
  public class HomeModule:NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=>View["index.cshtml"];
      Get["/add_job"]=_=>View["add_job.cshtml"];
      Get["/jobs"] =_=>{
        List<Job> jobList = Job.GetAll();
        return View["jobs.cshtml", jobList];
      };
      Post["/jobs"] = _ => {
        Job newJob = new Job (Request.Form["new-job"]);
        List<Job> jobList = Job.GetAll();
        return View["jobs.cshtml", jobList];
      };
      Get["/jobs/{cityName}"] = parameters => {
        Job job = Job.Find(parameters.cityName);
        return View["/job_details.cshtml", job];
      };
    }
  }
}
