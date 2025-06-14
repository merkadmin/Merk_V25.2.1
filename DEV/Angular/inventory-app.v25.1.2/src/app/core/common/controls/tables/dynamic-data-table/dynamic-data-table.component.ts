import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TableHeader } from '../../../../../logic/table/TableHeader';

@Component({
  selector: 'app-dynamic-data-table',
  imports: [
    CommonModule
  ],
  templateUrl: './dynamic-data-table.component.html',
  styleUrl: './dynamic-data-table.component.scss'
})
export class DynamicDataTableComponent {
  @Input() tableHeaders: TableHeader[] | undefined;
  @Input() tableData: any[] = [];
}
