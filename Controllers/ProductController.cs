namespace MegaventoryProject.Controllers
{
    public class ProductController : BaseApiController
    {
        [HttpPost("Product/")]
        public IActionResult ProductUpdate(mvProduct product)
        {
            var newProduct = new mvProduct
            {
                ProductID = product.ProductID,
                ProductDescription = product.ProductDescription,
                ProductSellingPrice = product.ProductSellingPrice,
                ProductPurchasePrice = product.ProductPurchasePrice
            };
            return Ok(newProduct);
        }
    }
}
