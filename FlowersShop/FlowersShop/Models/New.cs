using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersShop.Models
{
    public class New
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string SmallInfo { get; set; }
        public string BigInfo { get; set; }
    }
}
