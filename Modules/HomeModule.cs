using System.Collections.Generic;
using Nancy;
using myJob.Objects;

namespace myJobs
{
  public class HomeModule:NancyModule
  {
    public HomeModule()
    {
      int i=0;
      Get["/"]=_=>View["index.cshtml"];
      // Post["/addresponsibility"] =_=> {
      //   i++;
      //   return View["/add_jobs.cshtml", i];
      // };
      Get["/add_job"]=_=>View["add_job.cshtml"];
      Get["/jobs"] =_=>{
        List<Job> jobList = Job.GetAll();
        return View["jobs.cshtml", jobList];


      };
      Post["/jobs"] = _ => {
        Job newJob = new Job (Request.Form["new-job"]);
        //Loop through responsibility inputs
        for(int j = 0; j<Request.Form["number-of-responsibilities"]; j++)
        {
          string idString = "responsibility-description" + j;

          newJob.AddResponsibility(Request.Form[idString]);
        }
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
