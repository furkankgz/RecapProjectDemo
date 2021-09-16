using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        // operasyonları içeren interface
        //List<Car> GetAll();
        //List<Car> GetById(int brandId);
        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
