using CommonBL.Models;
using EntitiesBL.ModelEntities.GeneratedEnitities;

namespace CommonBL.Libs
{
	public class CommonBL
	{
		public static List<InventoryStoreModel> GetInventoryStores(InventoryDbContext? context, List<InventoryStoreCu> inventoryStores)
		{
			if (context == null || inventoryStores == null || inventoryStores.Count == 0)
			{
				return null;
			}

			List<InventoryStoreModel> inventoryStoreModels = new List<InventoryStoreModel>();

			foreach (InventoryStoreCu inventoryStore in inventoryStores)
			{
				InventoryStoreModel inventoryStoreModel = new InventoryStoreModel();
				inventoryStoreModel.InventoryStore = inventoryStore;
				InventoryCategoryCu? category = context.InventoryCategoryCus.FirstOrDefault(c => c.Id == inventoryStore.InventoryCategoryCuId);

				if (inventoryStoreModel.InventoryCategories == null)
					inventoryStoreModel.InventoryCategories = new List<InventoryCategoryCu>();

				if (category != null)
					inventoryStoreModel.InventoryCategories.Add(category);

				List<InventoryStoreCategoryCu> inventoryCategories = context.InventoryStoreCategoryCus.Where(item => item.InventoryStoreCuId == inventoryStore.Id).ToList();
				foreach (InventoryStoreCategoryCu storeCategoryCu in inventoryCategories)
				{
					category = context.InventoryCategoryCus.FirstOrDefault(item => item.Id == storeCategoryCu.InventoryCategoryCuId);
					if (category != null && !inventoryStoreModel.InventoryCategories.Exists(item => item.Id == category.Id))
						inventoryStoreModel.InventoryCategories.Add(category);
				}

				inventoryStoreModels.Add(inventoryStoreModel);
			}

			return inventoryStoreModels;
		}
	}
}
