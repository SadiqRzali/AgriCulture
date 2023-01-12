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
	public class SosialMediaManager : IISosialMediaService
	{
		private readonly ISosialMediaDal _sosialMediaDal;

		public SosialMediaManager(ISosialMediaDal sosialMediaDal)
		{
			_sosialMediaDal = sosialMediaDal;
		}

		public void Delete(SosialMedia t)
		{
			_sosialMediaDal.Delete(t);
		}

		public SosialMedia GetByID(int id)
		{
			return _sosialMediaDal.GetByID(id);
		}

		public List<SosialMedia> GetListAll()
		{
			return _sosialMediaDal.GetListAll();
		}

		public void Insert(SosialMedia t)
		{
			_sosialMediaDal.Insert(t);
		}

		public void Update(SosialMedia t)
		{
			_sosialMediaDal.Update(t);
		}
	}
}
