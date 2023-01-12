using BusinesLayer.Abstract;
using DataAcssesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _iadmindal;

        public AdminManager(IAdminDal iadmindal)
        {
            _iadmindal = iadmindal;
        }

        public void Delete(Admin t)
        {
            _iadmindal.Delete(t);
        }

        public Admin GetByID(int id)
        {
          return  _iadmindal.GetByID(id);
        }

        public List<Admin> GetListAll()
        {
            return _iadmindal.GetListAll();
        }

        public void Insert(Admin t)
        {
            _iadmindal.Insert(t);
        }

        public void Update(Admin t)
        {
            _iadmindal.Update(t);
        }
    }
}
