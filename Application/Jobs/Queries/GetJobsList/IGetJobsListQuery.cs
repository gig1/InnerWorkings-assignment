using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Jobs.Queries.GetJobsList
{
    public interface IGetJobsListQuery
    {
        List<JobsModel> Execute();
    }
}
