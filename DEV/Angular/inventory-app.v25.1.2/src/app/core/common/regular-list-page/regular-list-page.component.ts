import { AfterViewChecked, Component, CUSTOM_ELEMENTS_SCHEMA, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { ActionButtonComponent } from '../controls/actions/action-button/action-button.component';
import { DynamicDataTableComponent } from '../controls/tables/dynamic-data-table/dynamic-data-table.component';
import { SearchInputComponent } from '../controls/inputs/search-input/search-input.component';
import { TableHeader } from '../../../logic/table/TableHeader';
import { CommonModule } from '@angular/common';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';
import { NgxSpinnerService } from 'ngx-spinner';
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
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
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

  constructor(
    public gloablService: GlobalActionsService,
    private spinner: NgxSpinnerService
  ) {

  }

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
    this.spinner.show();
    this.gloablService.getData(this.gloablService.Controller, this.gloablService.API).subscribe({
      next: (response) => {
        this.gloablService.DataItemsLoaded = response.map(item => Object.assign({}, item));
        if(this.gloablService.DataItemsLoaded) {
            this.spinner.hide();
          }
      },
      error: (error) => {
          console.error('Error fetching inventory stores:', error);
        },
    });
  }
}
