import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { GenericAPICallingService } from '../../../services/common/generic-apicalling.service';
import { ActivatedRoute } from '@angular/router';
import { InventoryCategoryModel } from '../../../logic/models/InventoryCategoryModel';
import { Controller } from '../../../services/common/Controller';
import { API } from '../../../services/common/API';
import { RegularListPageComponent } from "../../../core/common/regular-list-page/regular-list-page.component";
import { InventoryCategories_TH } from '../../../logic/table/InventoryCategories_TH';
import { TableHeader } from '../../../logic/table/TableHeader';

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
    private apiCalling: GenericAPICallingService,
    private route: ActivatedRoute
  ) {

  }

  ngOnInit(): void {
    this.apiCalling.get<InventoryCategoryModel[]>(Controller.InventoryCategory, API.GetAll).subscribe(
      {
        next: (response: InventoryCategoryModel[]) => {
          this.Items = response;
          console.log('Inventory Stores fetched successfully:', this.Items);
        },
        error: (error) => {
          console.error('Error fetching inventory stores:', error);
        },
      }
    );
  }

  ngAfterViewInit(): void {

  }

  ngOnDestroy(): void {
    
  }
}
