using CQRSNight.Context;
using CQRSNight.CQRSDesingPattern.Queries.CategoryQueries;
using CQRSNight.CQRSDesingPattern.Results.CategoryResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _context.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = values.CategoryId,
                CategoryName = values.CategoryName
            };
        }
    }
}
