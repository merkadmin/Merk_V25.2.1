import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { GenericAPICallingService } from '../../../services/common/generic-apicalling.service';
import { InventoryStoreModel } from '../../../logic/models/InventoryStoreModel';
import { Controller } from '../../../services/common/Controller';
import { API } from '../../../services/common/API';
import { ActivatedRoute, RouterModule } from '@angular/router';

@Component({
  selector: 'app-inventory-stores-list',
  imports: [
    RouterModule,
  ],
  providers: 
  [

  ],
  templateUrl: './inventory-stores-list.component.html',
  styleUrl: './inventory-stores-list.component.scss',
})
export class InventoryStoresListComponent implements OnInit, AfterViewInit, OnDestroy
{
  Items: InventoryStoreModel[] = [];

  constructor(
    private apiCalling: GenericAPICallingService,
    private route: ActivatedRoute
  ) {

  }

  ngOnInit(): void {
    this.apiCalling.get<InventoryStoreModel[]>(Controller.InventoryStore, API.GetAll).subscribe(
      {
        next: (response: InventoryStoreModel[]) => {
          this.Items = response;
          console.log('Inventory Stores fetched successfully:', this.Items);
        },
        error: (error) => {
          console.error('Error fetching inventory stores:', error);
        },
      }
    );
  }
  ngAfterViewInit(): void {}
  ngOnDestroy(): void {}
}
