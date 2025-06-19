import {
  AfterViewInit,
  Component,
  CUSTOM_ELEMENTS_SCHEMA,
  OnDestroy,
  OnInit,
} from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { InventoryCategoryModel } from '../../../logic/models/InventoryCategoryModel';
import { Controller } from '../../../services/common/Controller';
import { API } from '../../../services/common/API';
import { InventoryCategories_TH } from '../../../logic/table/InventoryCategories_TH';
import { TableHeader } from '../../../logic/table/TableHeader';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { CommonModule } from '@angular/common';
import { Application } from '../../../services/Generic/Application';
import { RegularListCardComponent } from '../../../core/common/cards/regularListCards/regular-list-card/regular-list-card.component';
import { TranslateBL } from '../../../services/Generic/translate/TranslateBL';

@Component({
  selector: 'app-inventory-categories-list',
  imports: [
    RegularListCardComponent,
    CommonModule,
    NgxSpinnerModule,
    RouterModule,
  ],
  templateUrl: './inventory-categories-list.component.html',
  styleUrl: './inventory-categories-list.component.scss',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class InventoryCategoriesListComponent
  implements OnInit, AfterViewInit, OnDestroy
{
  tableHeaders: TableHeader[] = [new InventoryCategories_TH()];

  constructor(
    public gloablService: GlobalActionsService,
    private route: ActivatedRoute,
    private spinner: NgxSpinnerService
  ) {
    this.gloablService.setApplication(
      Controller.InventoryStore,
      API.GetAllIsOnDuty,
      Application.InventoryCategoryList,
      {
        PageTitleName_en: 'Category',
        PageTitleName_ar: 'فئة',
        PageTitleName_en_pl: 'Categories',
        PageTitleName_ar_pl: 'الفئات',
      }
    );

    console.log(
      'From Category this.gloablService.Controller',
      this.gloablService.Controller
    );
    console.log('From Category this.gloablService.API', this.gloablService.API);
  }

  ngOnInit(): void {}

  ngAfterViewInit(): void {
    this.spinner.show();

    this.gloablService
      .getData(this.gloablService.Controller, this.gloablService.API)
      .subscribe({
        next: (response: any[]) => {
          this.gloablService.DataItemsLoaded = response.map((item) =>
            Object.assign(new InventoryCategoryModel(), item)
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

  ngOnDestroy(): void {}
}
