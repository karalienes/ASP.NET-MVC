using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Traningİnfo
    {
        [Key]
        public int TraningİnfoId { get; set; }
        public DateTime CreateTime { get; set; }

        public int PeriyodId { get; set; }
        public virtual Periyod Periyod { get; set; }

        public int? TraningId { get; set; }
        public virtual Traning Traning { get; set; }

        public int UserID { get; set; }
        public virtual UserData UserData { get; set; }
    }
}
