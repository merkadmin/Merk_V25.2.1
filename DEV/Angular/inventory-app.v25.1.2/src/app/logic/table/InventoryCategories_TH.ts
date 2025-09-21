import { TableHeader } from "./TableHeader";

export class InventoryCategories_TH extends TableHeader {
    constructor() {
        super();
        this.tableHeaders = [
            { name: 'ID', label: 'ID', type: 'number' },
            { name: 'CategoryName_P', label: 'Name', type: 'string' },
            { name: 'CategoryDescription', label: 'Description', type: 'string' }
        ];
    }
}