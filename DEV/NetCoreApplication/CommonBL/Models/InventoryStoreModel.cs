using EntitiesBL.ModelEntities.GeneratedEnitities;

namespace CommonBL.Models
{
    public class InventoryStoreModel
    {
        public InventoryStoreCu InventoryStore { get; set; }
        public List<InventoryCategoryCu> InventoryCategories { get; set; }
    }
}
