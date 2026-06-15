using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;
using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            values.Email = command.Email;
            values.SendDate = command.SendDate;
            values.Name = command.Name;
            values.ContactID = command.ContactID;
            values.Subject = command.Subject;
            values.Message = command.Message;
            await _repository.UpdateAsync(values);
        }
}
}
