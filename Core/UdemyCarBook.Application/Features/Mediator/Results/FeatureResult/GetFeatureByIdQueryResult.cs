using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results.FeatureResult
{
    public class GetFeatureByIdQueryResult
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
    }
}
