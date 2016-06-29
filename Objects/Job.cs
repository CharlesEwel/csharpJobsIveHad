using System.Collections.Generic;

namespace myJob.Objects
{
  public class Job
  {
    private string _jobName;
    private List<string> _responsibilities = new List<string>{};
    private static List<Job> _instances = new List<Job>{};
    public Job(string JobName)
    {
      _jobName = JobName;
      _instances.Add(this);
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }
    public static Job Find(string searchJobName)
    {
      int counter=0;
      int searchIndex=0;
      foreach(var place in _instances)
      {
        if(place.GetJobName()==searchJobName)
        {
          searchIndex=counter;
        }
        counter++;
      }
      return _instances[searchIndex];
    }

    public string GetJobName()
    {
      return _jobName;
    }
    public void SetJobName(string newJobName)
    {
      _jobName = newJobName;
    }

    public void AddResponsibility(string newResponsibility)
    {
      _responsibilities.Add(newResponsibility);
    }
    public List<string> GetResponsibilities()
    {
      return _responsibilities;
    }
  }
}
