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
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _iaboutDal;

		public AboutManager(IAboutDal iaboutDal)
		{
			_iaboutDal = iaboutDal;
		}

		public void Delete(About t)
		{
			_iaboutDal.Delete(t);
		}

		public About GetByID(int id)
		{
			return _iaboutDal.GetByID(id);
		}

		public List<About> GetListAll()
		{
			return _iaboutDal.GetListAll();
		}

		public void Insert(About t)
		{
			_iaboutDal.Insert(t);
		}

		public void Update(About t)
		{
			_iaboutDal.Update(t);
		}
	}
}
