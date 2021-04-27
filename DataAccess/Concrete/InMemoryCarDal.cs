using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car{CarId=1,ColorId=1,BrandId=2,DailyPrice=350000,ModelYear=2021,Description="boyasız hatasız"},

                new Car{CarId=2,ColorId=1,BrandId=1,DailyPrice=300000,ModelYear=2020,Description="boyasız hatasız"},

                new Car{CarId=3,ColorId=1,BrandId=1,DailyPrice=30000,ModelYear=1999,Description="boyasız hatasız"},

                new Car{CarId=4,ColorId=1,BrandId=2,DailyPrice=100000,ModelYear=2009,Description="bir çamurluk boya"},


            };
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car ToDelete = cars.SingleOrDefault(c => c.CarId == car.CarId);
            cars.Remove(ToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public List<Car> GetAllByColor(int ColorId)
        {
            return cars.Where(c => c.ColorId== ColorId).ToList();
        }

        public void Update(Car car)
        {
            Car ToUpdate = cars.SingleOrDefault(c => c.CarId == car.CarId);

            ToUpdate.CarId =car.CarId;

            ToUpdate.BrandId = car.BrandId;

            ToUpdate.ColorId = car.ColorId;

            ToUpdate.DailyPrice= car.DailyPrice;

            ToUpdate.Description = car.Description;

            ToUpdate.ModelYear = car.ModelYear;

        }
    }
}

