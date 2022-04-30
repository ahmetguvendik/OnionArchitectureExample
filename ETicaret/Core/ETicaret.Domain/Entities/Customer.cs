using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public List<Order> Order { get; set; }
    }
}
