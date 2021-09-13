using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 2, ColorId = 3, DailyPrice = 20000, ModelYear = 1995, Description = "1995 Model Honda"},
                new Car{Id = 2, BrandId = 2, ColorId = 3, DailyPrice = 60000, ModelYear = 2006, Description = "2006 Model Honda"},
                new Car{Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 90000, ModelYear = 2012, Description = "2012 Model Honda"},
                new Car{Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 75000, ModelYear = 2007, Description = "2007 Model Mazda"},
                new Car{Id = 5, BrandId = 3, ColorId = 3, DailyPrice = 60000, ModelYear = 2006, Description = "2006 Model Mazda"},
                new Car{Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 200000, ModelYear = 2019, Description = "2019 Model Volvo"}
            };
        }
       

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            // Gönderdiğim araba id'sine sahip olan listedeki arabayı bul. 
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

        public void Delete(Car car)
        {
            
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}
