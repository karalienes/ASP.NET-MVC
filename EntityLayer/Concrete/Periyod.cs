using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Periyod
    {
        [Key]
        public int PeriyodId { get; set; }
        public string Yıl { get; set; }
        public string Ay { get; set; }

        public string Hafta { get; set; }

        public ICollection<Traningİnfo> Traningİnfos { get; set; }


       


    }
}
