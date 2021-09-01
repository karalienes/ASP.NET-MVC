using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TraningTypeManager : ITraningTypeService
    {
        GenericRepository<TraningType> repo = new GenericRepository<TraningType>();

        ITraningTypeDal _traningTypeDal;
        public TraningTypeManager(ITraningTypeDal traningTypeDal)
        {
            _traningTypeDal = traningTypeDal;
        }
        public void TraningTypeAddBL(TraningType tt)
        {
            _traningTypeDal.Insert(tt);
        }

        public List<TraningType> GetListBL()
        {
            return repo.List();
        }

        public TraningType GetByİşlemSıra(int ıd)
        {
            return _traningTypeDal.Get(x => x.TraningTypeId == ıd);
        }

        public void TraningTypeDelete(TraningType tt)
        {
            _traningTypeDal.Delete(tt);
        }

        public void TraningTypeUpdate(TraningType tt)
        {
            _traningTypeDal.Update(tt);
        }
    }
}
