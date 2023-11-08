// The second class
// ================

// Class: Resume
// ======

// Attributes
// ==========
// _name: string
// _job: List<job>

// Behavior
// ========
// DisplayPersonJobHistory(): void

public class Resume
{
    public string _name;
    public List<Job>_jobs = new List<Job>();

    public void DisplayPersonJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

}