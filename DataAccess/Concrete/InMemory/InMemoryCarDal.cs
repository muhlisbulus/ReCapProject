using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=30000,ModelYear=2000,Description="Boyasız-Hatasız"},
                 new Car{Id=1,BrandId=3,ColorId=4,DailyPrice=40000,ModelYear=2019,Description="Boyalı"}
            };
        }
        
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=cars.SingleOrDefault(c=>c.Id==car.Id);
            cars.Remove(carToDelete);
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

        public List<Car> GetByıd(int Id)
        {

            return cars.Where(c=>c.Id==Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(c =>c.Id == car.Id);
            carToUpdate.DailyPrice=car.DailyPrice;
           
            carToUpdate.ModelYear=car.ModelYear;
        }
    }
}
