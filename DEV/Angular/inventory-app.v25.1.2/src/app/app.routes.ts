import { Routes } from '@angular/router';
import { InventoryItemsListComponent } from './inventory/inventoryItems/inventory-items-list/inventory-items-list.component';
import { InventoryStoresListComponent } from './inventory/inventoryStore/inventory-stores-list/inventory-stores-list.component';
import { InventoryCategoriesListComponent } from './inventory/inventoryCategory/inventory-categories-list/inventory-categories-list.component';
import { SvgViewerComponent } from './tools/svg-viewer/svg-viewer.component';

export const routes: Routes = [
    {path: '', redirectTo: 'categories', pathMatch: 'full'},
    {path: 'stores', component: InventoryStoresListComponent},
    {path: 'categories', component: InventoryCategoriesListComponent},
    {path: 'items', component: InventoryItemsListComponent},
    {path: 'svg', component: SvgViewerComponent}
];
