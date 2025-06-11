import { ITableHeader } from "./ITableHeader";
import { ITableHeaderColumn } from "./ITableHeaderColumn";

export class TableHeader implements ITableHeader{
    tableHeaders: ITableHeaderColumn[] = [];
}