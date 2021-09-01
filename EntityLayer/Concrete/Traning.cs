using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Traning

    {
        [Key]
        public int TraningId { get; set; }
        
        public string TraningName { get; set; }

        public ICollection<Traningİnfo> Traningİnfos { get; set; }

      
        public int? TraningTypeId { get; set; }
        public virtual TraningType TraningTypes { get; set; }

        


    }
}
