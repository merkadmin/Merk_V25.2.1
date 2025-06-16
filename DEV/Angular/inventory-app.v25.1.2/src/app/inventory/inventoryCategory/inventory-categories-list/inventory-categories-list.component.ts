import { AfterViewInit, ChangeDetectorRef, Component, OnDestroy, OnInit } from '@angular/core';
import { GenericAPICallingService } from '../../../services/common/generic-apicalling.service';
import { ActivatedRoute } from '@angular/router';
import { InventoryCategoryModel } from '../../../logic/models/InventoryCategoryModel';
import { Controller } from '../../../services/common/Controller';
import { API } from '../../../services/common/API';
import { RegularListPageComponent } from "../../../core/common/regular-list-page/regular-list-page.component";
import { InventoryCategories_TH } from '../../../logic/table/InventoryCategories_TH';
import { TableHeader } from '../../../logic/table/TableHeader';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';

@Component({
  selector: 'app-inventory-categories-list',
  imports: [RegularListPageComponent],
  templateUrl: './inventory-categories-list.component.html',
  styleUrl: './inventory-categories-list.component.scss'
})
export class InventoryCategoriesListComponent implements OnInit, AfterViewInit, OnDestroy{
  Items: InventoryCategoryModel[] = [];
  tableHeaders: TableHeader[] = [new InventoryCategories_TH()];

  constructor(
    private gloablService: GlobalActionsService,
    private route: ActivatedRoute,
    private cdr: ChangeDetectorRef
  ) {

  }

  ngOnInit(): void {
    this.cdr.detectChanges();
  }

  ngAfterViewInit(): void {
    this.gloablService.getData(Controller.InventoryCategory, API.GetAll);
    console.log('************* ', this.gloablService.Items);
    this.Items = this.gloablService.Items as InventoryCategoryModel[];
  }

  ngOnDestroy(): void {
    
  }
}
