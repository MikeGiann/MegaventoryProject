namespace MegaventoryProject.Entities
{
    public class mvSalesOrder
    {
        public string SalesOrderStatus { get; set; } = "Pending";
        public int SalesOrderTypeId { get; set; }
        public int SalesOrderClientID { get; set; }
        public string SalesOrderBillingAddress { get; set; }
        public string SalesOrderShippingAddress { get; set; }
        public string SalesOrderContactPerson { get; set; }
        public double SalesOrderAmountSubtotalWithoutTaxAndDiscount { get; set; }
        public int SalesOrderInventoryLocationID { get; set; }
        public double SalesOrderAmountTotalDiscount { get; set; }
        public double SalesOrderAmountTotalTax { get; set; }
        public double SalesOrderAmountGrandTotal { get; set; }
        public mvDiscount Discount { get; set; }
        public mvInventoryLocation Location { get; set; }
        public mvProduct Product { get; set; }
        public mvSupplierClient Client { get; set; }
        public mvTax Tax { get; set; }
        public mvSalesOrderDetails SalesOrderDetails { get; set; }

    }
}
