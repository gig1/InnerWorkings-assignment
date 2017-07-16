using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Jobs;
using System.Data.Entity.ModelConfiguration;

namespace Persistance.Jobs
{
    public class JobConfiguration: EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
            //HasKey(k => k.Id);
        }
    }
}
