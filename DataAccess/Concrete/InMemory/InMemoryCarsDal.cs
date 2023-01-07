using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarsDal: ICarsDal
    {
        List<Cars> _cars;
        public InMemoryCarsDal()
        {
            _cars = new List<Cars>
            {
                new Cars{Id=1,BrandId=12,ColorId=5,ModelYear=2018,DailyPrice=479000,Description="Sedan Tip Araç"},
                new Cars{Id=4,BrandId=12,ColorId=1,ModelYear=2012,DailyPrice=370000,Description="Sedan Tip Araç"},
                new Cars{Id=3,BrandId=13,ColorId=4,ModelYear=2019,DailyPrice=52000,Description="SUV Tip Araç"},
                new Cars{Id=2,BrandId=10,ColorId=3,ModelYear=2016,DailyPrice=420000,Description="HB Kasa Araç"},
            };
            
         }
        public List<Cars> GetById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }
        public List<Cars> GetAll()
        {
            return _cars;
        }
        
        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete;

            carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public void Update(Cars car)
        {
            Cars carToUpdate;
            carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Cars Get(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
