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
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());



            //carManager.Add(new Car { Id=4, BrandId=4, ColorId=4, DailyPrice=400, Description="Dizel",ModelYear=2020-01-01 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
        }
    }
}
