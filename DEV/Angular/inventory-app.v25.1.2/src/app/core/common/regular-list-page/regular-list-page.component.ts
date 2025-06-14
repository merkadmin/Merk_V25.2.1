import { Component, Input } from '@angular/core';
import { ActionButtonComponent } from "../controls/actions/action-button/action-button.component";
import { DynamicDataTableComponent } from "../controls/tables/dynamic-data-table/dynamic-data-table.component";
import { SearchInputComponent } from "../controls/inputs/search-input/search-input.component";
import { TableHeader } from '../../../logic/table/TableHeader';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-regular-list-page',
  imports: 
  [
    CommonModule,
    ActionButtonComponent, 
    DynamicDataTableComponent, 
    SearchInputComponent
  ],
  templateUrl: './regular-list-page.component.html',
  styleUrl: './regular-list-page.component.scss'
})
export class RegularListPageComponent {
  @Input() tableHeaders: TableHeader[] | undefined;
  @Input() showSearchInput: boolean | undefined;
  @Input() EntityName: string | undefined;
  @Input() showFilterButton: boolean | undefined;
  @Input() showExportButton: boolean | undefined;
  @Input() showAddButton: boolean | undefined;
  @Input() tableData: any[] | undefined;
}
