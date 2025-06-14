import {
  AfterViewInit,
  Component,
  EventEmitter,
  Input,
  OnChanges,
  Output,
  SimpleChanges,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { TableHeader } from '../../../../../logic/table/TableHeader';
declare const KTMenu: any;

@Component({
  selector: 'app-dynamic-data-table',
  imports: [CommonModule],
  templateUrl: './dynamic-data-table.component.html',
  styleUrl: './dynamic-data-table.component.scss',
})
export class DynamicDataTableComponent implements AfterViewInit, OnChanges {
  @Input() tableHeaders: TableHeader[] | undefined;
  @Input() tableData: any[] = [];
  @Input() showTableRowActions: boolean | undefined;

  @Output() selectionChanged = new EventEmitter<boolean>();

  selectedRows: Set<number> = new Set();

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

  onSelectAllChange(event: Event) {
    const checked = (event.target as HTMLInputElement).checked;
    
    this.selectedRows.clear();
    if (checked) {
      this.tableData.forEach((_, idx) => this.selectedRows.add(idx));
    }

    this.selectionChanged.emit(this.selectedRows.size > 0);
  }

  onCheckboxChange(index: number, event: Event) {
    const checked = (event.target as HTMLInputElement).checked;

    if (checked) {
      this.selectedRows.add(index);
    } else {
      this.selectedRows.delete(index);
    }

    this.selectionChanged.emit(this.selectedRows.size > 0);
  }
}
