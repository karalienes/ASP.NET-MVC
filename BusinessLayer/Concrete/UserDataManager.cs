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
    public class UserDataManager : IUserDataService
    {
        GenericRepository<UserData> repo = new GenericRepository<UserData>();

        IUserDataDal _userDataDal;
        public UserDataManager(IUserDataDal userDataDal)
        {
            _userDataDal = userDataDal;
        }
        public void UserDataAddBL(UserData ud)
        {
            _userDataDal.Insert(ud); 
        }

        public List<UserData> GetListBL()
        {
            return repo.List();
        }

        public UserData GetByİşlemSıra(int ıd)
        {
            return _userDataDal.Get(x => x.UserID == ıd);
        }

        public void UserDelete(UserData ud)
        {
            _userDataDal.Delete(ud);
        }

        public void USerDataUpdate(UserData ud)
        {
            _userDataDal.Update(ud);
        }
        //public void UserDataAddBL(UserData p)
        //{
        //    if (p.AdSoyad == "" || p.AdSoyad.Length < 3
        //        || p.AdSoyad.Length > 51)
        //    {
        //        //hata mesajı yazdırsın.


        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
    }
}
