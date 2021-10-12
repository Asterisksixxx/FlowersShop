using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace FlowersShop.Models
{
    public class Flower
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SmallImageLink { get; set; }
        public string BigImageLink { get; set; }
        public string SmallInfo { get; set; }
        public string BigInfo { get; set; }

    }
}
