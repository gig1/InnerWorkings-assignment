using Domain.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<Job> Jobs { get; set; }
        IDbSet<JobDescription> JobDescriptions { get; set; }

        void Save();
    }
}
