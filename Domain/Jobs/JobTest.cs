using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domain.Jobs
{
    [TestFixture]
    public class JobTest
    {
        private readonly Job _job;
        private const int Id = 1;
        private const string Name = "Test";
        private const bool isExtraMargin = true;
        private const decimal TotalPrice = 100.00m;

        public JobTest()
        {
            _job = new Job();
        }

        [Test]
        public void JobTestSetAndGetId()
        {
            _job.Id = Id;

            Assert.That(_job.Id, Is.EqualTo(Id));
        }

        [Test]
        public void JobTestSetAndGetName()
        {
            _job.Name = Name;

            Assert.That(_job.Name,
                Is.EqualTo(Name));
        }

        [Test]
        public void JobTestSetAndGetIsExtraMargin()
        {
            _job.isExtraMargin = isExtraMargin;

            Assert.That(_job.isExtraMargin,
                Is.EqualTo(isExtraMargin));
        }

        [Test]
        public void JobTestSetAndGetTotalPrice()
        {
            _job.TotalPrice = TotalPrice;

            Assert.That(_job.TotalPrice,
                Is.EqualTo(TotalPrice));
        }
    }
}
