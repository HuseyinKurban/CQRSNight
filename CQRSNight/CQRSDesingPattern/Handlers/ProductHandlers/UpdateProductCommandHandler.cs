using CQRSNight.Context;
using CQRSNight.CQRSDesingPattern.Commands.ProductCommands;

namespace CQRSNight.CQRSDesingPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand command)
        {
            var values = await _context.Products.FindAsync(command.ProductId);
            values.ProductName = command.ProductName;
            values.ProductPrice = command.ProductPrice;
            values.ProductStock = command.ProductStock;
            await _context.SaveChangesAsync();
        }
    }
}
