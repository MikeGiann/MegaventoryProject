namespace MegaventoryProject.Controllers
{
    public class SalesOrderController : BaseApiController
    {
        [HttpPost("SalesOrder/")]
        public IActionResult SalesOrderUpdate(mvSalesOrder salesOrder)
        {
            var newSalesOrder = new mvSalesOrder
            {
                SalesOrderStatus = salesOrder.SalesOrderStatus,
                SalesOrderTypeId = salesOrder.SalesOrderTypeId,
                SalesOrderClientID = salesOrder.Client.SupplierClientID,
                SalesOrderShippingAddress = salesOrder.Client.SupplierClientShippingAddress1,
                SalesOrderContactPerson = salesOrder.Client.SupplierClientPhone1,
                SalesOrderAmountSubtotalWithoutTaxAndDiscount = salesOrder.Product.ProductPurchasePrice,
                SalesOrderAmountTotalDiscount = salesOrder.Discount.DiscountValue,
                SalesOrderAmountTotalTax = salesOrder.Tax.TaxValue,
                SalesOrderAmountGrandTotal = salesOrder.Product.ProductSellingPrice,
            };
            return Ok(newSalesOrder);
        }
    }
}
