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
    public class TraningManager : ITraningService
    {
        GenericRepository<Traning> repo = new GenericRepository<Traning>();

        ITraningDal _traningDal;
        public TraningManager(ITraningDal traningDal)
        {
            _traningDal = traningDal;
        }
        public void TraningAddBL(Traning t)
        {
            _traningDal.Insert(t);
        }

        public List<Traning> GetListBL()
        {
            return repo.List();
        }

        public Traning GetByİşlemSıra(int ıd)
        {
            return _traningDal.Get(x => x.TraningId == ıd);
        }

        public void TraningDelete(Traning t)
        {
            _traningDal.Delete(t);
        }

        public void TraningUpdate(Traning t)
        {
            _traningDal.Update(t);
        }
    }
}
