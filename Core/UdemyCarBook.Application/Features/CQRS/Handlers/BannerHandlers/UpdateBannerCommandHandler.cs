using System;
using System.Collections.Generic;
using System.Text;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);
            values.Title = command.Title;
            values.VideoDescription = command.VideoDescription;
            values.Description = command.Description;
            values.VideoUrl = command.VideoUrl;
            await _repository.UpdateAsync(values);

        }
    }
}
