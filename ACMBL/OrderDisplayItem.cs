namespace ACMBL
{
    public class OrderDisplayItem
    {
        public int OrderItemId { get; private set; }
        public int OrderQuntity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}