import { Component } from '@angular/core';
import { InventoryItems_TH } from '../../../../../logic/table/inventoryItems_TH';
import { CommonModule } from '@angular/common';
import { ITableHeader } from '../../../../../logic/table/ITable';

@Component({
  selector: 'app-dynamic-data-table',
  imports: [
    CommonModule
  ],
  templateUrl: './dynamic-data-table.component.html',
  styleUrl: './dynamic-data-table.component.scss'
})
export class DynamicDataTableComponent {
  tableHeaders: ITableHeader[] = 
  [
    { name: 'id', label: 'ID', type: 'number' },
    { name: 'name', label: '111', type: 'string' },
    { name: 'category', label: '222', type: 'string' },
    { name: 'quantity', label: '333', type: 'number' },
    { name: 'unitPrice', label: '444', type: 'number' },
    { name: 'totalValue', label: '555', type: 'number' },
    { name: 'supplierName', label: '666', type: 'string' },
    { name: 'lastUpdated', label: '777', type: 'date' }
  ];
  tableData: any[] = [];
}
