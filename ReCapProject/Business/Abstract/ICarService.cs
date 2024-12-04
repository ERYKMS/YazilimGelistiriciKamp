﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetBGetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void addCar(Car car);


    }
}
