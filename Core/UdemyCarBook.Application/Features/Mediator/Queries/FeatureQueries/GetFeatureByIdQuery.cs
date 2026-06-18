using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery: IRequest<GetFeatureByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }
    }
}
