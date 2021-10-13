using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersShop.Models
{
    public class Korzina
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid FlowerId { get; set; }
        public int FlowersCount { get; set; }
        public decimal FlowersPrice { get; set; }
    }
}
