import { Routes } from '@angular/router';
import { InventoryItemsListComponent } from './inventory/inventoryItems/inventory-items-list/inventory-items-list.component';

export const routes: Routes = [
    {path: '', redirectTo: 'inventoryItemsList', pathMatch: 'full'},
    {path: 'inventoryItemsList', component: InventoryItemsListComponent},
];
