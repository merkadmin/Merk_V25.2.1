import { AfterViewChecked, Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { TableHeader } from '../../../../../logic/table/TableHeader';
import { RegularListCardListingComponent } from '../regular-list-card-listing/regular-list-card-listing.component';
import { RegularListCardTopComponent } from '../regular-list-card-top/regular-list-card-top.component';
import { GlobalActionsService } from '../../../../../services/Generic/global-actions.service';
import { NgxSpinnerService } from 'ngx-spinner';
declare const KTMenu: any;

@Component({
  selector: 'app-regular-list-card',
  imports: [
    RegularListCardListingComponent,
    RegularListCardTopComponent
  ],
  templateUrl: './regular-list-card.component.html',
  styleUrl: './regular-list-card.component.scss'
})
export class RegularListCardComponent implements OnInit, OnChanges, AfterViewChecked {
  @Input() tableHeaders: TableHeader[] | undefined;
  @Input() tableData: any[] | undefined;
  @Input() showTableRowActions: boolean | undefined;

  @Input() showSearchInput: boolean | undefined;
  @Input() EntityName: string | undefined;
  @Input() showFilterButton: boolean | undefined;
  @Input() showExportButton: boolean | undefined;
  @Input() showAddButton: boolean | undefined;

  @Input() showActionMenu: boolean = false;

  constructor(
    public gloablService: GlobalActionsService,
    private spinner: NgxSpinnerService
  ){

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
