using EntitiesBL.ModelEntities.CommonBL;
using System;
using System.Collections.Generic;

namespace EntitiesBL.ModelEntities.GeneratedEnitities;

public partial class InventoryStoreCategoryCu
{
    public long Id { get; set; }

    public long InventoryStoreCuId { get; set; }

    public long InventoryCategoryCuId { get; set; }

    public bool IsOnDuty { get; set; }

    public long? InsertedBy { get; set; }

    public DateTime? InsertedDate { get; set; }

    public virtual InventoryCategoryCu InventoryCategoryCu { get; set; } = null!;

    public virtual InventoryStoreCu InventoryStoreCu { get; set; } = null!;
}
