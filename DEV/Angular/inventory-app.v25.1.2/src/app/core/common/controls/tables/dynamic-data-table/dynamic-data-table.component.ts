import { AfterViewInit, Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TableHeader } from '../../../../../logic/table/TableHeader';
declare const KTMenu: any;

@Component({
  selector: 'app-dynamic-data-table',
  imports: [
    CommonModule
  ],
  templateUrl: './dynamic-data-table.component.html',
  styleUrl: './dynamic-data-table.component.scss'
})
export class DynamicDataTableComponent implements AfterViewInit, OnChanges {
  @Input() tableHeaders: TableHeader[] | undefined;
  @Input() tableData: any[] = [];
  @Input() showTableRowActions: boolean | undefined;

  ngAfterViewInit(): void {
    if (typeof KTMenu !== 'undefined') {
      KTMenu.createInstances();
    }
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (typeof KTMenu !== 'undefined') {
      setTimeout(() => KTMenu.createInstances(), 0);
    }
  }
}
