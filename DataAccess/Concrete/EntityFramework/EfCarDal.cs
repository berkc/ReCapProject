using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from car in context.Car
                             join brand in context.Brand
                             on car.BrandId equals brand.BrandId
                             join color in context.Color
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                CarName=car.CarName,
                                ColorName=color.ColorName,
                                BrandName=brand.BrandName,
                                DailyPrice=car.DailyPrice
                                 
                             };
                return result.ToList();
            }
        }
    }
}
