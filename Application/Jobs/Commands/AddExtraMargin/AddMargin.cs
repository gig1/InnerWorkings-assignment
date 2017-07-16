using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Jobs;

namespace Application.Jobs.Commands.AddExtraMargin
{
    public class AddMargin: IAddMargin
    {
        private readonly IDatabaseService _database;
        private readonly decimal extraMarginCharge = .05m;
        private readonly decimal marginCharge = .11m;
        private decimal tax = .07m;

        public AddMargin(IDatabaseService database)
        {
            _database = database;
        }

        public void AddMarginToTotalPrice()
        {
            var jobs = _database.Jobs.ToList();
            var jobDescriptions = _database.JobDescriptions.ToList();

            foreach(Job job in jobs)
            {
                tax = .07m;
                if (job.isExtraMargin)
                {
                    var specificJobs = jobDescriptions.Where(s => s.JobName == job.Name).ToList();
                    decimal price = 0;
                    decimal totalPrice = 0;
                    foreach (var item in specificJobs)
                    {
                        price = item.Price;
                        if (item.isExempt)
                        {
                            tax = 0;
                        }
                        //totalPrice += Math.Round(price * (1 + marginCharge + extraMarginCharge + tax), 2);
                        totalPrice += price * (1 + marginCharge + extraMarginCharge + tax);
                    }
                    
                    job.TotalPrice = totalPrice;
                }
                else
                {
                    var specificJobs = jobDescriptions.Where(s => s.JobName == job.Name).ToList();
                    decimal price = 0;
                    decimal totalPrice = 0;
                    foreach (var item in specificJobs)
                    {
                        price = item.Price;
                        if (item.isExempt)
                        {
                            tax = 0;
                        }
                        //totalPrice += Math.Round((price * (1 + marginCharge + tax)), 2);
                        totalPrice += price * (1 + marginCharge + tax);

                    }
                    job.TotalPrice = totalPrice;
                }
            }

            _database.Save();
        }
    }
}
