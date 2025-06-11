import { Component } from '@angular/core';
import { SearchInputComponent } from "../../../core/common/controls/inputs/search-input/search-input.component";
import { ActionButtonComponent } from "../../../core/common/controls/actions/action-button/action-button.component";
import { CommonModule } from '@angular/common';
import { DynamicDataTableComponent } from "../../../core/common/controls/tables/dynamic-data-table/dynamic-data-table.component";

@Component({
  selector: 'app-inventory-items-list',
  imports: [
    SearchInputComponent,
    ActionButtonComponent,
    CommonModule,
    DynamicDataTableComponent
],
  templateUrl: './inventory-items-list.component.html',
  styleUrl: './inventory-items-list.component.scss'
})
export class InventoryItemsListComponent {

}
