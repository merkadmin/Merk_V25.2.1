import { AfterViewChecked, Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { ActionButtonComponent } from '../controls/actions/action-button/action-button.component';
import { DynamicDataTableComponent } from '../controls/tables/dynamic-data-table/dynamic-data-table.component';
import { SearchInputComponent } from '../controls/inputs/search-input/search-input.component';
import { TableHeader } from '../../../logic/table/TableHeader';
import { CommonModule } from '@angular/common';
declare const KTMenu: any;

@Component({
  selector: 'app-regular-list-page',
  imports: [
    CommonModule,
    ActionButtonComponent,
    DynamicDataTableComponent,
    SearchInputComponent,
  ],
  templateUrl: './regular-list-page.component.html',
  styleUrl: './regular-list-page.component.scss',
})
export class RegularListPageComponent implements OnInit, OnChanges, AfterViewChecked {
  @Input() tableHeaders: TableHeader[] | undefined;
  @Input() tableData: any[] | undefined;
  @Input() showTableRowActions: boolean | undefined;

  @Input() showSearchInput: boolean | undefined;
  @Input() EntityName: string | undefined;
  @Input() showFilterButton: boolean | undefined;
  @Input() showExportButton: boolean | undefined;
  @Input() showAddButton: boolean | undefined;

  @Input() showActionMenu: boolean = false;

  @Output() refresData = new EventEmitter<void>();

  ngOnInit(): void {
    
  }

  ngAfterViewChecked(): void {
    if (this.showActionMenu && typeof KTMenu !== 'undefined') {
      KTMenu.createInstances();
    }
  }

  ngOnChanges(changes: SimpleChanges): void {
  
  }

  onSelectionChanged(anySelected: boolean) {
    this.showActionMenu = anySelected;
    if (this.showActionMenu) {
      setTimeout(() => {
        if (typeof KTMenu !== 'undefined') {
          KTMenu.createInstances();
        }
      });
   }
  }

  onRefreshData(){
    console.log('Data refreshed!');
  }
}
