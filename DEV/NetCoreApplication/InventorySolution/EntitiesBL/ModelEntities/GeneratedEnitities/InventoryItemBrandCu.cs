using System;
using System.Collections.Generic;

namespace EntitiesBL.ModelEntities.GeneratedEnitities;

public partial class InventoryItemBrandCu
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

    public virtual ICollection<InventoryItemCu> InventoryItemCus { get; set; } = new List<InventoryItemCu>();
}
