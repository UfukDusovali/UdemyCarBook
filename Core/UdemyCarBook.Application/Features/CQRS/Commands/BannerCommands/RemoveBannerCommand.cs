using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBannerCommand
    {
        public RemoveBannerCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }


    }
}

