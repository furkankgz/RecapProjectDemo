using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("---------------------------------");

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
            Console.WriteLine("-----------------------------------");

            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId + "\n");
            }
            Console.WriteLine("--------------------------------------");
            foreach (var car in carManager.GetUnitPrice(20000, 25000))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId + "\n");
            }
        }
    }
}
