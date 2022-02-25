namespace MegaventoryProject.Entities
{
    public class mvProduct
    {
        public int ProductID { get; set; }
        [Required]
        public string ProductSKU { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        public double ProductSellingPrice { get; set; }
        public double ProductPurchasePrice { get; set; }
    }
}
