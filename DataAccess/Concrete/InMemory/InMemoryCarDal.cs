using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=250,ModelYear=2020,Description="Son Model" },
             new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=550,ModelYear=2016,Description="Sahibinden" },
              new Car{CarId=3,BrandId=2,ColorId=1,DailyPrice=450,ModelYear=2017,Description="Galeriden" },
               new Car{CarId=4,BrandId=3,ColorId=2,DailyPrice=150,ModelYear=2018,Description="İşletmeden" },
                new Car{CarId=5,BrandId=3,ColorId=2,DailyPrice=350,ModelYear=2019,Description="Kiralık" },


            };
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
          return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public List<Car> GetById()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
