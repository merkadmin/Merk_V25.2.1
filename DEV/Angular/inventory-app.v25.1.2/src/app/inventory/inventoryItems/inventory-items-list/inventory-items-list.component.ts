import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InventoryItems_TH } from '../../../logic/table/inventoryItems_TH';

@Component({
  selector: 'app-inventory-items-list',
  imports: [
    CommonModule,
  ],
  templateUrl: './inventory-items-list.component.html',
  styleUrl: './inventory-items-list.component.scss',
})
export class InventoryItemsListComponent
  implements OnInit, AfterViewInit, OnDestroy
{
  tableHeader = new InventoryItems_TH();

  constructor (){

  }

  ngOnInit(): void {
    
  }

  ngAfterViewInit(): void {

  }

  ngOnDestroy(): void {

  }
}
