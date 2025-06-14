using EntitiesBL.ModelEntities.CommonBL;

namespace EntitiesBL.ModelEntities.GeneratedEnitities;

public partial class InventoryCategoryCu
{
    public long Id { get; set; }

    public string NameP { get; set; } = null!;

    public string? NameS { get; set; }

    public int? ChartOfAccountCuId { get; set; }

    public string? InternalCode { get; set; }

    public string? Description { get; set; }

    public bool IsOnDuty { get; set; }

    public long? InsertedBy { get; set; }

    public DateTime? InsertedDate { get; set; }

    public virtual ICollection<InventoryItemCategoryCu> InventoryItemCategoryCus { get; set; } = new List<InventoryItemCategoryCu>();

    public virtual ICollection<InventoryStoreCategoryCu> InventoryStoreCategoryCus { get; set; } = new List<InventoryStoreCategoryCu>();
}
