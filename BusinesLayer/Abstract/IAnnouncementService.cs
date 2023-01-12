﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IAnnouncementService:IGenericService<Announcement>
    {
        void AnnounTrue(int id);
        void AnnounFalse(int id);
    }
}
