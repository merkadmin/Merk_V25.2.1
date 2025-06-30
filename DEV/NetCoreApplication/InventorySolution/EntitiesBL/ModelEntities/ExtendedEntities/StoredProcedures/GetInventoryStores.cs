using EntitiesBL.ModelEntities.CommonBL;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitiesBL.ModelEntities.GeneratedEnitities
{
    public class GetInventoryStores: IDBCommon
    {
        public long? InventoryStoreID { get; set; }
        public string? InventoryStoreInternalCode { get; set; }
        public string? InventoryStoreNameP { get; set; }
        public string? InventoryStoreNameS { get; set; }
        public long? ParentInventoryStoreID { get; set; }
        public bool? InventoryStoreIsFavorite { get; set; }
        public bool? InventoryStoreIsMain { get; set; }
        public bool? InventoryStoreUseAcceptReceive { get; set; }
        public long? InventoryStoreDepartmentID { get; set; }
        public long? InventoryStoreInChargeID { get; set; }
        public long? InventoryStoreInsertedBy { get; set; }
        public DateTime? InventoryStoreInsertedDate { get; set; }
        public string? ParentInventoryStoreNameP { get; set; }
        public string? ParentInventoryStoreNameS { get; set; }
        public long? InventoryCategoryID { get; set; }
        public string? InventoryCategoryInternalCode { get; set; }
        public string? InventoryCategoryNameP { get; set; }
        public string? InventoryCategoryNameS { get; set; }
        public string? InventoryCategoryDescription { get; set; }
        public long? InventoryCategoryInsertedBy { get; set; }
        public DateTime? InventoryCategoryInsertedDate { get; set; }

        #region Implementation of IDBCommon

        [NotMapped]
        public bool IsOnDuty { get; set; }

        #endregion
    }
}
