using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarsManager _carsManager = new CarsManager(new InMemoryCarsDal());

            //foreach (var car in _carsManager.GetAll())
            //{
            //    Console.WriteLine(car.Id);
            //}
            BrandsManager _brandsManager = new BrandsManager(new EfBrandDal());

            foreach (var brand in _brandsManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(brand.Name);
            }
        }
    }
}
