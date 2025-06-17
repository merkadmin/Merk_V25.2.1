import { Component, Input } from '@angular/core';
import { TableHeader } from '../../../../../logic/table/TableHeader';

@Component({
  selector: 'app-regular-list-card',
  imports: [],
  templateUrl: './regular-list-card.component.html',
  styleUrl: './regular-list-card.component.scss'
})
export class RegularListCardComponent {
  @Input() tableHeaders: TableHeader[] | undefined;
  @Input() tableData: any[] | undefined;
  @Input() showTableRowActions: boolean | undefined;

  @Input() showSearchInput: boolean | undefined;
  @Input() EntityName: string | undefined;
  @Input() showFilterButton: boolean | undefined;
  @Input() showExportButton: boolean | undefined;
  @Input() showAddButton: boolean | undefined;

  @Input() showActionMenu: boolean = false;

  constructor(){
    
  }
}
