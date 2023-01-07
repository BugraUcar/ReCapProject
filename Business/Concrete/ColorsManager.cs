using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorsManager : IColorService
    {
        IColorDal _colorDal;

        public ColorsManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Colors> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(p => p.Id == id);
        }
    }
}
