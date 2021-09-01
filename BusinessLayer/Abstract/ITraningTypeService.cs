using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITraningTypeService
    {
        
        List<TraningType> GetListBL();

        void TraningTypeAddBL(TraningType Tt);

        TraningType GetByİşlemSıra(int ıd);
        void TraningTypeDelete(TraningType Tt);
        void TraningTypeUpdate(TraningType Tt);
    }
}
