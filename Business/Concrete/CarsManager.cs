using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CarsManager : ICarsService
    {
        ICarsDal _carsDal;

        public CarsManager(ICarsDal carsDal)
        {
            _carsDal = carsDal;
        }

        public List<Cars> GetAll()
        {
            return _carsDal.GetAll();
        }

        
    }
}
