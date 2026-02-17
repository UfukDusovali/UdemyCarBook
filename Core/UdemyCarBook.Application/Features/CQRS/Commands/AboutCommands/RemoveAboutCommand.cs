using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public RemoveAboutCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
