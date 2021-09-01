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
    public class PeriyodManager :IPeriyodService
    {
        GenericRepository<Periyod> repo = new GenericRepository<Periyod>();

        IPeriyodDal _periyodDal;
        public PeriyodManager(IPeriyodDal periyodDal)
        {
            _periyodDal = periyodDal;
        }
        public void PeriyodAddBL(Periyod p)
        {
            _periyodDal.Insert(p);
        }

        public List<Periyod> GetListBL()
        {
            return repo.List();
        }

        public Periyod GetByİşlemSıra(int ıd)
        {
            return _periyodDal.Get(x => x.PeriyodId == ıd);
        }

        public void PeriyodDelete(Periyod p)
        {
            _periyodDal.Delete(p);
        }

        public void PeriyodUpdate(Periyod p)
        {
            _periyodDal.Update(p);
        }
    }
}
