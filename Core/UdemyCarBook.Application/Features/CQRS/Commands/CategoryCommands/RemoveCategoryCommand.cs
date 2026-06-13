using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
