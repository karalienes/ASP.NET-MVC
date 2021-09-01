using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPeriyodService
    {
        List<Periyod> GetListBL();

        void PeriyodAddBL(Periyod p);

        Periyod GetByİşlemSıra(int ıd);
        void PeriyodDelete(Periyod p);
        void PeriyodUpdate(Periyod p);
    }
}
