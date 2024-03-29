﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public interface ICarService
    {
      IDataResult<List<Car>>GetAll();
       IResult Add(Car car);
       IDataResult< List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);

     IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
