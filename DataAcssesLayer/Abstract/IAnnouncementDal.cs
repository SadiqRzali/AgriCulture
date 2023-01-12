using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcssesLayer.Abstract
{
    public interface IAnnouncementDal:IGenericDal<Announcement>
    {
        void AnnounTrue(int id);
        void AnnounFalse(int id);
    }
}
