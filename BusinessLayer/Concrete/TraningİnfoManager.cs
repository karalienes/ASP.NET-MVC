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
    public class TraningİnfoManager : ITraningİnfoService
    {
        GenericRepository<Traningİnfo> repo = new GenericRepository<Traningİnfo>();

        ITraningİnfoDal _traningİnfoDal;
        public TraningİnfoManager(ITraningİnfoDal traningİnfoDal)
        {
            _traningİnfoDal = traningİnfoDal;
        }
        public void TraningİnfoAddBL(Traningİnfo ti)
        {
            _traningİnfoDal.Insert(ti);
        }

        public List<Traningİnfo> GetListBL()
        {
            return repo.List();
        }

        public Traningİnfo GetByİşlemSıra(int ıd)
        {
            return _traningİnfoDal.Get(x => x.TraningİnfoId == ıd);
        }

        public void TraningİnfoDelete(Traningİnfo ti)
        {
            _traningİnfoDal.Delete(ti);
        }

        public void TraningİnfoUpdate(Traningİnfo ti)
        {
            _traningİnfoDal.Update(ti);
        }
    }
}
