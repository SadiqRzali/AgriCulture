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
    public class ImageManager : IImageService
    {

        private readonly IImageDal _ImageDal;

        public ImageManager(IImageDal imageDal)
        {
            _ImageDal = imageDal;
        }

        public void Delete(Image t)
        {
            _ImageDal.Delete(t);
        }

        public Image GetByID(int id)
        {
            return _ImageDal.GetByID(id);
        }

        public List<Image> GetListAll()
        {
            return _ImageDal.GetListAll();
        }

        public void Insert(Image t)
        {
            _ImageDal.Insert(t);
        }

        public void Update(Image t)
        {
            _ImageDal.Update(t);
        }
    }
}
