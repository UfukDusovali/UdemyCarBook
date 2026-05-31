using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _Repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _Repository = repository;
        }

        public async Task Handle( CreateBannerCommand command)
        {
            var values = _Repository.CreateAsync(new Banner
            {
                Description = command.Description,
                Title = command.Title,
                VideoDescription = command.VideoDescription,
                VideoUrl=command.VideoUrl,
            });
        }
    }
}
