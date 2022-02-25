namespace MegaventoryProject.Controllers
{
    public class DiscountController : BaseApiController
    {
        [HttpPost("Discount/")]
        public async Task<IActionResult> DiscountUpdate(mvDiscount discount)
        {
            var newDiscount = new mvDiscount
            {
                DiscountID = discount.DiscountID,
                DiscountName = discount.DiscountName,
                DiscountDescription = discount.DiscountDescription,
                DiscountValue = discount.DiscountValue,
            };
            return Ok(newDiscount);
        }

    }
}
