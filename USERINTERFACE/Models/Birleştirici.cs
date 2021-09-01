using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace USERINTERFACE.Models
{
    public class Birleştirici
    {
        public IEnumerable<UserData> UserDatas { get; set; }
        public IEnumerable<Periyod> Periyods { get; set; }
        public IEnumerable<Traning> Tranings { get; set; }

        public IEnumerable<Traningİnfo> Traningİnfos { get; set; }

        public IEnumerable<TraningType> TraningTypes { get; set; }
    }
}