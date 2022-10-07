namespace dddPrg.Domain.CommandResults
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