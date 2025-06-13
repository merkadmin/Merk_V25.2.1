import { Routes } from '@angular/router';
import { InventoryItemsListComponent } from './inventory/inventoryItems/inventory-items-list/inventory-items-list.component';
import { InventoryStoresListComponent } from './inventory/inventoryStore/inventory-stores-list/inventory-stores-list.component';
import { InventoryCategoriesListComponent } from './inventory/inventoryCategory/inventory-categories-list/inventory-categories-list.component';

export const routes: Routes = [
    {path: '', redirectTo: 'settings/items', pathMatch: 'full'},
    {path: 'settings/stores', component: InventoryStoresListComponent},
    {path: 'settings/categories', component: InventoryCategoriesListComponent},
    {path: 'settings/items', component: InventoryItemsListComponent},
];
