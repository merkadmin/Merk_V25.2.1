using EntitiesBL.ModelEntities.CommonBL;
using System;
using System.Collections.Generic;

namespace EntitiesBL.ModelEntities.GeneratedEnitities;

public partial class InventoryStoreCu
{
    public long Id { get; set; }

    public string NameP { get; set; } = null!;

    public string? NameS { get; set; }

    public long? ParentInventoryStoreCuId { get; set; }

    public long? InventoryCategoryCuId { get; set; }

    public bool? IsFavorite { get; set; }

    public bool IsMain { get; set; }

    public bool? UseAcceptReceive { get; set; }

    public long? DepartmentCuId { get; set; }

    public long? InChargeId { get; set; }

    public long? LocationCuId { get; set; }

    public long? FloorCuId { get; set; }

    public int? ChartOfAccountCuId { get; set; }

    public string? InternalCode { get; set; }

    public string? Description { get; set; }

    public bool IsOnDuty { get; set; }

    public long? InsertedBy { get; set; }

    public DateTime? InsertedDate { get; set; }

    public virtual ICollection<InventoryStoreCategoryCu> InventoryStoreCategoryCus { get; set; } = new List<InventoryStoreCategoryCu>();
}
