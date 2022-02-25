namespace MegaventoryProject.Controllers
{
    public class SupplierClientController : BaseApiController
    {
        [HttpPost("SupplierClient/")]
        public IActionResult SupplierClientUpdate(mvSupplierClient supplierClient)
        {
            var newSupplierClient = new mvSupplierClient
            {
                SupplierClientID = supplierClient.SupplierClientID,
                SupplierClientName = supplierClient.SupplierClientName,
                SupplierClientEmail = supplierClient.SupplierClientEmail,
                SupplierClientShippingAddress1 = supplierClient.SupplierClientShippingAddress1,
                SupplierClientPhone1 = supplierClient.SupplierClientPhone1
            };
            return Ok(newSupplierClient);
        }
    }
}
