using System;
using System.Collections.Generic;
using System.Reflection;


namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string argName, Employer argEmployerName, Location argEmployerLocation, PositionType argJobType, CoreCompetency argJobCoreCompetency) : this()
        {
            Name = argName;
            EmployerName = argEmployerName;
            EmployerLocation = argEmployerLocation;
            JobType = argJobType;
            JobCoreCompetency = argJobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            //TODO: find a solution that does not involve .Replace
            FieldInfo[] fields = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            List<string> holderList = new List<string>();
            foreach (var field in fields)
            {
                if ($"{field.GetValue(this)}" == (""))
                {
                    holderList.Add((field.Name + ": " + "Data not available"));
                }
                else
                {
                    holderList.Add((field.Name + ": " + field.GetValue(this))); 
                }
                
            }

            string __return = ("\n" + string.Join("\n", holderList) + "\n").Replace("k__BackingField", "").Replace("<", "").Replace(">",""); 
            return __return;
            
            //Brute force partial solution:
            //return "\nID: " + this.Id + "\nName: " + this.Name + "\nEmployer: " + this.EmployerName + "\nLocation: " + this.EmployerLocation + "\nPosition Type: " + this.JobType + "\nCore Competency: " + this.JobCoreCompetency + "\n";
        }

    }
}
