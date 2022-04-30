using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Adress { get; set; }
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }

}
