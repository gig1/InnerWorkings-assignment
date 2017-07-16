using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Jobs
{
    public class JobDescription: IEntity
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool isExempt { get; set; }
        public decimal PriceWithTax { get; set; }
    }
}
