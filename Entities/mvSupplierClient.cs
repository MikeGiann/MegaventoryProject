namespace MegaventoryProject.Entities
{
    public class mvSupplierClient
    {
        public int SupplierClientID { get; set; }
        [Required]
        public string SupplierClientName { get; set; }
        [EmailAddress]
        public string SupplierClientEmail { get; set; }
        public string SupplierClientShippingAddress1 { get; set; }
        [Phone]
        public string SupplierClientPhone1 { get; set; }
    }
}
