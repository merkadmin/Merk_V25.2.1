namespace EntitiesBL.ModelEntities.GeneratedEnitities;

public partial class InventoryItemCategoryCu
{
    public long Id { get; set; }

    public long InventoryItemCuId { get; set; }

    public long InventoryCategoryCuId { get; set; }

    public bool IsOnDuty { get; set; }

    public long? InsertedBy { get; set; }

    public DateTime? InsertedDate { get; set; }

    public virtual InventoryCategoryCu InventoryCategoryCu { get; set; } = null!;

    public virtual InventoryItemCu InventoryItemCu { get; set; } = null!;
}
