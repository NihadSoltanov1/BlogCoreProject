using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;

        public AdminManager(IAdminDal admindal)
        {
            _admindal = admindal;
        }

        public void TDelete(Admin t)
        {
            throw new NotImplementedException();
        }

        public List<Admin> TGetAllList(int id)
        {
            return _admindal.GetAllList(x=>x.AdminID==id);
                }

        public Admin TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> TGetList(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Admin t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}
