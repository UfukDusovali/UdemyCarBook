using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        Task<List<Car>>GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
    }
}
