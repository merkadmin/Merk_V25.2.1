import {
  AfterViewInit,
  Component,
  CUSTOM_ELEMENTS_SCHEMA,
  OnDestroy,
  OnInit,
} from '@angular/core';
import { GenericAPICallingService } from '../../../services/common/generic-apicalling.service';
import { InventoryStoreModel } from '../../../logic/models/InventoryStoreModel';
import { Controller } from '../../../services/common/Controller';
import { API } from '../../../services/common/API';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { RegularListCardComponent } from '../../../core/common/cards/regularListCards/regular-list-card/regular-list-card.component';
import { CommonModule } from '@angular/common';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { TableHeader } from '../../../logic/table/TableHeader';
import { InventoryStores_TH } from '../../../logic/table/InventoryStores_TH';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';
import { Application } from '../../../services/Generic/Application';

@Component({
  selector: 'app-inventory-stores-list',
  imports: [
    RegularListCardComponent,
    CommonModule,
    NgxSpinnerModule,
    RouterModule,
  ],
  providers: [],
  templateUrl: './inventory-stores-list.component.html',
  styleUrl: './inventory-stores-list.component.scss',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class InventoryStoresListComponent
  implements OnInit, AfterViewInit, OnDestroy{
  tableHeaders: TableHeader[] = [new InventoryStores_TH()];

  constructor(
    public gloablService: GlobalActionsService,
    private route: ActivatedRoute,
    private spinner: NgxSpinnerService
  ) {
    this.gloablService.setApplication(
      Controller.InventoryStore, 
      API.GetAllIsOnDuty, 
      Application.InventoryStoresList,
      {
        PageTitleName_en: 'Store',
        PageTitleName_ar: 'مخزن',
        PageTitleName_en_pl: 'Stores',
        PageTitleName_ar_pl: 'المخازن',
      }
    );

    console.log('From Store this.gloablService.Controller', this.gloablService.Controller);
    console.log('From Store this.gloablService.API', this.gloablService.API);
  }

  ngOnInit(): void {

  }

  ngAfterViewInit(): void {
    this.spinner.show();

    this.gloablService
      .getData(this.gloablService.Controller, this.gloablService.API)
      .subscribe({
        next: (response: any[]) => {
          this.gloablService.DataItemsLoaded = response.map((item) =>
            Object.assign(new InventoryStoreModel(), item)
          );
          if (this.gloablService.DataItemsLoaded) {
            this.spinner.hide();
          }
        },
        error: (error) => {
          console.error('Error fetching inventory stores:', error);
        },
      });
  }

  ngOnDestroy(): void {
    
  }
}
