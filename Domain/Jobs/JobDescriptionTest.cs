using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domain.Jobs
{
    [TestFixture]
    public class JobDescriptionTest
    {
        private readonly JobDescription _jobDescription;
        private const int Id = 1;
        private const string JobName = "Job 1";
        private const string Name = "Test";
        private const decimal Price = 22.5m;
        private const bool isExempt = true;
        private const decimal PriceWithTax = 111.11m;

        public JobDescriptionTest()
        {
            _jobDescription = new JobDescription();
        }

        [Test]
        public void JobDescriptionTestSetAndGetId()
        {
            _jobDescription.Id = Id;

            Assert.That(_jobDescription.Id, Is.EqualTo(Id));
        }

        [Test]
        public void JobDescriptionTestSetAndGetJobName()
        {
            _jobDescription.JobName = JobName;

            Assert.That(_jobDescription.JobName, Is.EqualTo(JobName));
        }

        [Test]
        public void JobDescriptionTestSetAndGetName()
        {
            _jobDescription.Name = Name;

            Assert.That(_jobDescription.Name, Is.EqualTo(Name));
        }

        [Test]
        public void JobDescriptionTestSetAndGetPrice()
        {
            _jobDescription.Price = Price;

            Assert.That(_jobDescription.Price, Is.EqualTo(Price));
        }

        [Test]
        public void JobDescriptionTestSetAndGetIsExempt()
        {
            _jobDescription.isExempt = isExempt;

            Assert.That(_jobDescription.isExempt, Is.EqualTo(isExempt));
        }

        [Test]
        public void JobDescriptionTestSetAndGetPriceWithTax()
        {
            _jobDescription.PriceWithTax = PriceWithTax;

            Assert.That(_jobDescription.PriceWithTax, Is.EqualTo(PriceWithTax));
        }
    }

}
