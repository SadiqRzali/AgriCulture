using DataAcssesLayer.Abstract;
using DataAcssesLayer.Concrete;
using DataAcssesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.EntityFramvork
{
    public class EFAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void AnnounFalse(int id)
        {
            using var context = new Context();
            Announcement p = context.Announcements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void AnnounTrue(int id)
        {
            using var context = new Context();
            Announcement p = context.Announcements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
