using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Jobs.Commands.AddTax;
using Application.Jobs.Commands.AddExtraMargin;

namespace Application.Jobs.Queries.GetJobsList
{
    public class GetJobsListQuery : IGetJobsListQuery
    {
        private readonly IDatabaseService _database;
        private readonly IAddTax _tax;
        private readonly IAddMargin _margin;

        public GetJobsListQuery(IDatabaseService database,
            IAddTax tax,
            IAddMargin margin)
        {
            _database = database;
            _tax = tax;
            _margin = margin;
        }

        public List<JobsModel> Execute()
        {
            _tax.AddTextToPrice();
            _margin.AddMarginToTotalPrice();

            var jobs = (from j in _database.Jobs join jd in _database.JobDescriptions on j.Name equals jd.JobName
                       select new JobsModel
                       {
                           JobName = j.Name,
                           JobIsExtraMargin = j.isExtraMargin,
                           DescName = jd.Name,
                           Price = jd.PriceWithTax,
                           isExempt = jd.isExempt,
                           TotalPrice = j.TotalPrice
                       });

            return jobs.ToList();
        }
    }
}
