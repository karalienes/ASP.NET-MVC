using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ITraningİnfoService
    {
        List<Traningİnfo> GetListBL();

        void TraningİnfoAddBL(Traningİnfo Ti);

        Traningİnfo GetByİşlemSıra(int ıd);
        void TraningİnfoDelete(Traningİnfo Ti);
        void TraningİnfoUpdate(Traningİnfo Ti);
    }
}
