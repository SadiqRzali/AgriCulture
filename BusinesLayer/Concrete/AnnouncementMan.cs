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
    public class AnnouncementMan : IAnnouncementService
    {
        private readonly IAnnouncementDal _iannouncementDal;

        public AnnouncementMan(IAnnouncementDal iannouncementDal)
        {
            _iannouncementDal = iannouncementDal;
        }

        public void AnnounFalse(int id)
        {
            _iannouncementDal.AnnounFalse(id);
        }

        public void AnnounTrue(int id)
        {
            _iannouncementDal.AnnounTrue(id);
        }

        public void Delete(Announcement t)
        {
            _iannouncementDal.Delete(t);
        }

        public Announcement GetByID(int id)
        {
            return _iannouncementDal.GetByID(id);
        }

        public List<Announcement> GetListAll()
        {
            return _iannouncementDal.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _iannouncementDal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _iannouncementDal.Update(t);
        }
    }
}
