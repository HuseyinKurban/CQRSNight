namespace CQRSNight.CQRSDesingPattern.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public int ProductId { get; set; }

        public GetProductByIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
