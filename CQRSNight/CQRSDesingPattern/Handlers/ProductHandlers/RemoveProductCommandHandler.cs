using CQRSNight.Context;
using CQRSNight.CQRSDesingPattern.Commands.ProductCommands;

namespace CQRSNight.CQRSDesingPattern.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand command)
        {
            var value = await _context.Products.FindAsync(command.ProductId);
            _context.Products.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
