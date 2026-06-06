using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _Repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _Repository = repository;
        }

        public async Task Handle( CreateCarCommand command)
        {
            await _Repository.CreateAsync(new Car
            {
                BrandID = command.BrandID,
                Fuel = command.Fuel,
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl = command.CoverImageUrl,
                Km = command.Km,
                Luggage = command.Luggage,
                Transmission = command.Transmission,
                Seat = command.Seat,
                Model = command.Model
            });
        }

    }
}
