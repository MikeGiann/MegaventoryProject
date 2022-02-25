namespace MegaventoryProject.Controllers
{
    public class TaxController : BaseApiController
    {
        [HttpPost("Tax/")]
        public IActionResult TaxUpdate(mvTax tax)
        {
            var newTax = new mvTax
            {
                TaxID = tax.TaxID,
                TaxName = tax.TaxName,
                TaxDescription = tax.TaxDescription,
                TaxValue = tax.TaxValue,
            };
            return Ok(newTax);
        }
    }
}
