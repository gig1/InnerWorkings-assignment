using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Jobs;
using Application.Interfaces;
using Application.Jobs.Commands.AddTax;

namespace Application.Jobs.Commands.UpdateJobsPrice
{
    public class AddTax: IAddTax
    {
        private readonly IDatabaseService _database;
        private readonly decimal tax = .07m;

        public AddTax(IDatabaseService database)
        {
            _database = database;
        }

        public void AddTextToPrice()
        {
            var jobs = _database.JobDescriptions.ToList();
            foreach(JobDescription job in jobs)
            {
                if (job.PriceWithTax == 0)
                {
                    if (!job.isExempt)
                    {
                        job.PriceWithTax += job.Price * (1 + tax);
                    }
                    else
                    {
                        job.PriceWithTax = job.Price;
                    }
                }
            }

            _database.Save();
        }
    }
}
