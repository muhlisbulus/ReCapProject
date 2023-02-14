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
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context =new ReCapContext())
            {
                var result = from C in context.Cars
                             join B in context.Brands
                             on C.BrandId equals B.BrandId
                             join Co in context.Colors on
                             C.ColorId equals Co.ColorId
                             select new CarDetailDto()
                             {
                                 BrandName= B.BrandName,
                                 CarName = C.CarName,
                                 ColorName = Co.ColorName,
                                 DailyPrice = C.DailyPrice



                             };
                return result.ToList();

            }
        }
    }
}
