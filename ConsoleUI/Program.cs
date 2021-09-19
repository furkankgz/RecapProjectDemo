using System;
using System.Collections.Generic;
using System.Threading.Channels;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCar();
            //AddBrand();
            //AddColor();
            CarTest();
            //CarGetAll();
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + " " + car.DailyPrice + " tl");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " | " + car.BrandName + " | " + car.ColorName + " ");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {ColorId = 1, ColorName = "Siyah"});
            colorManager.Add(new Color {ColorId = 2, ColorName = "Beyaz"});
            colorManager.Add(new Color {ColorId = 3, ColorName = "Mavi"});

            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                BrandId = 1,
                BrandName = "Mazda"
            });
            brandManager.Add(new Brand
            {
                BrandId = 2,
                BrandName = "Honda"
            });
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Id = 1,
                Description = "Honda 2006",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 2000,
                ModelYear = 2005
            });
        }

    }
}
