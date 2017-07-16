using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Jobs.Queries.GetJobsList
{
    public class JobsModel
    {
        //public int Id { get; set; }
        public string JobName { get; set; }
        public bool JobIsExtraMargin { get; set; }
        public string DescName { get; set; }
        public decimal Price { get; set; }
        public bool isExempt { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
