using System;
using System.Collections.Generic;

namespace EntitiesBL.ModelEntities.GeneratedEnitities;

public partial class InventoryItemCu
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public bool? IsFavorite { get; set; }

    public string NameP { get; set; } = null!;

    public string? NameS { get; set; }

    public bool? IsAvailable { get; set; }

    public bool? IsCountable { get; set; }

    public string? InternalCode { get; set; }

    public string? ItemSku { get; set; }

    public string? AbbreviationName { get; set; }

    public string? DefaultBarcode { get; set; }

    public long? InventoryItemCategoryCuId { get; set; }

    public long? InventoryItemBrandCuId { get; set; }

    public int InventoryItemStateSellingTypePId { get; set; }

    public int InventoryItemStatePurchasingTypePId { get; set; }

    public int? InventoryItemTypePId { get; set; }

    public int InventoryItemInvoicingStrategyPId { get; set; }

    public string? Description { get; set; }

    public int? CustomerDaysLimit { get; set; }

    public DateTime? SellingStartDate { get; set; }

    public DateTime? SellingEndDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public int? SizeUnitMeasurePId { get; set; }

    public double? Area { get; set; }

    public int? AreaUnitMeasurePId { get; set; }

    public double? Volume { get; set; }

    public int? VolumeUnitMeasurePId { get; set; }

    public double? Weight { get; set; }

    public int? WeightUnitPId { get; set; }

    public bool? UseElectronicScale { get; set; }

    public string? InDescription { get; set; }

    public string? OutDescription { get; set; }

    public double? DefaultSellingPrice { get; set; }

    public double? MinSellingPrice { get; set; }

    public double? PurchasingPrice { get; set; }

    public string? PurchasingDescription { get; set; }

    public bool IsOnDuty { get; set; }

    public long? InsertedBy { get; set; }

    public DateTime? InsertedDate { get; set; }

    public virtual InventoryItemBrandCu? InventoryItemBrandCu { get; set; }

    public virtual InventoryItemCategoryCu? InventoryItemCategoryCu { get; set; }
}
