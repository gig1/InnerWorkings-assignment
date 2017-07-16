using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Jobs
{
    public class Job : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isExtraMargin { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
