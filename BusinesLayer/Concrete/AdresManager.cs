using BusinesLayer.Abstract;
using DataAcssesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class AdresManager : IAdresService
    {
        private readonly IAdresDal _adresdal;

        public AdresManager(IAdresDal adresdal)
        {
            _adresdal = adresdal;
        }

        public void Delete(Adres t)
        {
            _adresdal.Delete(t);
        }

        public Adres GetByID(int id)
        {
            return _adresdal.GetByID(id);
        }

        public List<Adres> GetListAll()
        {
            return _adresdal.GetListAll();
        }

        public void Insert(Adres t)
        {
            _adresdal.Insert(t);
        }

        public void Update(Adres t)
        {
            _adresdal.Update(t);
        }
    }
}
