using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IUserDataService
    {
        List<UserData> GetListBL();

        void UserDataAddBL(UserData ud);

        UserData GetByİşlemSıra(int ıd);
        void UserDelete(UserData ud);
        void USerDataUpdate(UserData ud);
    }
}
