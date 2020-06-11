using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;


namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Job(string argName, Employer argEmployerName, Location argEmployerLocation, PositionType argJobType, CoreCompetency argJobCoreCompetency)
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }

        //Create First Test for ToString()
        [TestMethod]
        public void TestBlankLineBeforeAndAfter()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string test = job4.ToString();
            Assert.IsFalse(test.Length == test.Trim().Length);
        }

        //Finish the TDD for ToString()
        [TestMethod]
        public void TestFieldLabel()
        {
            Job job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string test = job5.ToString();
            string expected = "\nID: " + job5.Id + "\nName: " + "Product tester" + "\nEmployer: " + "ACME" + "\nLocation: " + "Desert" + "\nPosition Type: " + "Quality control" + "\nCore Competency: " + "Persistence" + "\n";
            Assert.IsTrue(test == expected);
        }
    }
}
