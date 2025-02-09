﻿using CQRSNight.Context;
using CQRSNight.CQRSDesingPattern.Commands.CategoryCommands;

namespace CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var values=await _context.Categories.FindAsync(command.CategoryId);
            values.CategoryName= command.CategoryName;
            await _context.SaveChangesAsync();
        }
    }
}
