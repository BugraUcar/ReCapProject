using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandsManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandsManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(p => p.Id == id);
        }
    }
}
