using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITraningService
    {
        List<Traning> GetListBL();

        void TraningAddBL(Traning t);

        Traning GetByİşlemSıra(int ıd);
        void TraningDelete(Traning t);
        void TraningUpdate(Traning t);
    }
}
