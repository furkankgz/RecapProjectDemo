using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int brandId);
        List<Car> GetUnitPrice(decimal min, decimal max);
        List<Car> GetCarsByColorId(int colorId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }

}
