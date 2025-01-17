using CQRSNight.Context;
using CQRSNight.CQRSDesingPattern.Results.CategoryResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values=await _context.Categories.ToListAsync();
            return values.Select(x=> new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
            }).ToList();
        }
    }
}
