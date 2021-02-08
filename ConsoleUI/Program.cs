using DataAccess.Concrete.InMemory;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();

            //BrandTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice );
            }

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(brandManager.GetById(1));

            brandManager.Add(new Brand { BrandId = 4, BrandName = "Mercedes" });

            brandManager.Update(new Brand { BrandId = 4, BrandName = "Tofaş" });

            brandManager.Delete(new Brand { BrandId = 4 });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine(colorManager.GetById(1));

            colorManager.Add(new Color { ColorId = 4, ColorName = "Gri" });

            colorManager.Update(new Color { ColorId = 4, ColorName = "Bordo" });

            colorManager.Delete(new Color { ColorId = 4 });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine(carManager.GetById(1));

            carManager.Add(new Car { Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 400, Description = "Dizel", ModelYear = 20201 });

            carManager.Update(new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 250, Description = "Dizel", ModelYear = 2019 });

            carManager.Delete(new Car { Id = 4 });
        }
    }
}
