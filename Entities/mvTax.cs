namespace MegaventoryProject.Entities
{
    public class mvTax
    {
        public int TaxID { get; set; }
        [Required]
        public string TaxName { get; set; }
        public string TaxDescription { get; set; }
        [Required]
        public double TaxValue { get; set; }
    }
}
