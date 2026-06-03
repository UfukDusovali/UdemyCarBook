using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Application.Features.CQRS.Queries.CarQueries;
using UdemyCarBook.Application.Features.CQRS.Results.CarResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _Repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _Repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _Repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID=values.BrandID,
                CarID=values.CarID,
                BigImageUrl=values.BigImageUrl,
                CoverImageUrl=values.CoverImageUrl,
                Fuel=values.Fuel,
                Km=values.Km,
                Luggage=values.Luggage,
                Model=values.Model,
                Seat=values.Seat,
                Transmission= values.Transmission                
            };
        }
    }
}
