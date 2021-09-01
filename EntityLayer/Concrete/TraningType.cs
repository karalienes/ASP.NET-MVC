using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TraningType
    {
        [Key]
        public int TraningTypeId { get; set; }

        public string TraningTypee { get; set; }

       
        public ICollection<Traning> Tranings { get; set; }



    }
}
