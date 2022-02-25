namespace MegaventoryProject.Entities
{
    public class mvSalesOrderDetails
    {
        public int SalesOrderRowProductID { get; set; }
        public string SalesOrderRowProductSKU { get; set; }
        public double SalesOrderRowQuantity { get; set; }
        public double SalesOrderRowUnitPriceWithoutTaxOrDiscount { get; set; }
    }
}
