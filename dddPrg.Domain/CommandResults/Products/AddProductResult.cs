namespace dddPrg.Domain.CommandResults.Products
{
    public class AddProductResult
    {
        public AddProductResult(int productId)
        {
            Id = productId;
        }

        public int Id { get; set; }
    }
}