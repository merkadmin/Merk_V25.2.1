import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InventoryItemsListComponent } from './inventoryItems/inventory-items-list/inventory-items-list.component';
import { SearchInputComponent } from '../core/common/controls/inputs/search-input/search-input.component';



@NgModule({
  declarations: [],
  imports: [
    InventoryItemsListComponent,
    SearchInputComponent
  ],
  exports: [
    
  ],
})
export class InventoryModule { }
