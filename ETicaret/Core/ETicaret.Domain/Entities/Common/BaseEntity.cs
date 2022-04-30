using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities.Common
{
    public class BaseEntity
    {
        //Bütün Entitilerde olacak ortak propları buraya veririz !!
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
