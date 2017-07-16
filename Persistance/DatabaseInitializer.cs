using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Jobs;

namespace Persistance
{
    public class DatabaseInitializer: CreateDatabaseIfNotExists<DatabaseService>
    {
        protected override void Seed(DatabaseService database)
        {
            base.Seed(database);

            CreateJobs(database);
            CreateJobDescriptions(database);

        }

        private void CreateJobs(DatabaseService database)
        {
            database.Jobs.Add(new Job
            {
                Id = 1,
                Name = "Job 1",
                isExtraMargin = true
            });

            database.Jobs.Add(new Job
            {
                Id = 2,
                Name = "Job 2",
                isExtraMargin = false
            });

            database.Jobs.Add(new Job
            {
                Id = 3,
                Name = "Job 3",
                isExtraMargin = true
            });

            database.SaveChanges();
        }

        private void CreateJobDescriptions(DatabaseService database)
        {
            database.JobDescriptions.Add(new JobDescription
            {
                Id = 1,
                JobName = "Job 1",
                Name = "envelopes",
                Price = 520,
                isExempt = false,
                PriceWithTax = 0
            });

            database.JobDescriptions.Add(new JobDescription
            {
                Id = 1,
                JobName = "Job 1",
                Name = "letterheads",
                Price = 1983.37m,
                isExempt = true,
                PriceWithTax = 0
            });

            database.JobDescriptions.Add(new JobDescription
            {
                Id = 2,
                JobName = "Job 2",
                Name = "t-shirts",
                Price = 294.04m,
                isExempt = false,
                PriceWithTax = 0
            });

            database.JobDescriptions.Add(new JobDescription
            {
                Id = 3,
                JobName = "Job 3",
                Name = "frisbees",
                Price = 19385.38m,
                isExempt = true,
                PriceWithTax = 0
            });

            database.JobDescriptions.Add(new JobDescription
            {
                Id = 3,
                JobName = "Job 3",
                Name = "yo-yos",
                Price = 1829,
                isExempt = true,
                PriceWithTax = 0
            });
        }
    }
}
