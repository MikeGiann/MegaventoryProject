namespace MegaventoryProject.Entities
{
    public class mvDiscount
    {
        public int DiscountID { get; set; }
        [Required]
        public string DiscountName { get; set; }
        public string DiscountDescription { get; set; }
        [Required]
        public double DiscountValue { get; set; }
    }
}
