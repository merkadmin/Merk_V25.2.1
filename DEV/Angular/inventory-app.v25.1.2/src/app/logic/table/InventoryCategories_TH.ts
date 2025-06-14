import { TableHeader } from "./TableHeader";

export class InventoryCategories_TH extends TableHeader {
    constructor() {
        super();
        this.tableHeaders = [
            { name: 'EntityID', label: 'ID', type: 'number' },
            { name: 'NameP', label: 'Name', type: 'string' },
            { name: 'Description', label: 'Description', type: 'string' }
        ];
    }
}