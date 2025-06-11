import { Component } from '@angular/core';
import { SearchInputComponent } from "../../../core/common/controls/inputs/search-input/search-input.component";
import { ActionButtonComponent } from "../../../core/common/controls/actions/action-button/action-button.component";

@Component({
  selector: 'app-inventory-items-list',
  imports: [SearchInputComponent, ActionButtonComponent],
  templateUrl: './inventory-items-list.component.html',
  styleUrl: './inventory-items-list.component.scss'
})
export class InventoryItemsListComponent {

}
