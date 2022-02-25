namespace MegaventoryProject.Entities
{
    public class mvInventoryLocation
    {
        public int InventoryLocationID { get; set; }
        [Required]
        public string InventoryLocationAbbreviation { get; set; }
        [Required]
        public string InventoryLocationName { get; set; }
        public string InventoryLocationAddress { get; set; }

    }
}
