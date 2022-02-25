namespace MegaventoryProject.Controllers
{
    public class InventoryLocationController : BaseApiController
    {
        [HttpPost("InventoryLocation/")]
        public IActionResult InventoryLocationUpdate(mvInventoryLocation inventoryLocation)
        {
            var newInventoryLocation = new mvInventoryLocation
            {
                InventoryLocationID = inventoryLocation.InventoryLocationID,
                InventoryLocationAbbreviation = inventoryLocation.InventoryLocationAbbreviation,
                InventoryLocationName = inventoryLocation.InventoryLocationName,
                InventoryLocationAddress = inventoryLocation.InventoryLocationAddress,
            };

            return Ok(newInventoryLocation);
        }

    }
}
