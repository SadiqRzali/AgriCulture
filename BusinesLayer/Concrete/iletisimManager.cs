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
    public class iletisimManager : IiletisimService
    {
        private readonly IiletisimDal _iletisimDal;

        public iletisimManager(IiletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public void Delete(iletisim t)
        {
            _iletisimDal.Delete(t);
        }

        public iletisim GetByID(int id)
        {
            return _iletisimDal.GetByID(id);
        }

        public List<iletisim> GetListAll()
        {
            return _iletisimDal.GetListAll();
        }

        public void Insert(iletisim t)
        {
            _iletisimDal.Insert(t);
        }

        public void Update(iletisim t)
        {
            _iletisimDal.Update(t);
        }
    }
}
