using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery:IRequest<List<GetFeatureQueryResult>>
    {
    }
}
