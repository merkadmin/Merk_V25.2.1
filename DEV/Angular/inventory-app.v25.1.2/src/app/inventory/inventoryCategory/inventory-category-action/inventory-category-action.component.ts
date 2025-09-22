import { AfterViewInit, Component, CUSTOM_ELEMENTS_SCHEMA, OnDestroy, OnInit } from '@angular/core';
import { RegularListCardComponent } from '../../../core/common/cards/regularListCards/regular-list-card/regular-list-card.component';
import { CommonModule } from '@angular/common';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';
import { Controller } from '../../../services/common/Controller';
import { API } from '../../../services/common/API';
import { Application } from '../../../services/Generic/Application';
import { TableHeader } from '../../../logic/table/TableHeader';
import { InventoryCategories_TH } from '../../../logic/table/InventoryCategories_TH';

@Component({
  selector: 'app-inventory-category-action',
  imports: [
    CommonModule,
    NgxSpinnerModule,
    RouterModule,
  ],
  templateUrl: './inventory-category-action.component.html',
  styleUrl: './inventory-category-action.component.scss',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class InventoryCategoryActionComponent implements OnInit, AfterViewInit, OnDestroy{
 
  constructor(
    public gloablService: GlobalActionsService,
    private route: ActivatedRoute,
    private spinner: NgxSpinnerService) { 
      this.gloablService.setApplication(
        Controller.InventoryCategory,
        API.SaveItem,
        Application.InventoryCategoryAction,
      );
  }

  ngOnInit(): void {

  }
  
  ngAfterViewInit(): void {

  }

  ngOnDestroy(): void {

  }

}
