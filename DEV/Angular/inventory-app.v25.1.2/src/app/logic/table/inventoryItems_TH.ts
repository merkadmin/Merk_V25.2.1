import { TableHeader } from "./TableHeader";

export class InventoryItems_TH extends TableHeader {
    constructor() {
        super();
        this.tableHeaders = [
            { name: 'id', label: 'ID', type: 'number' },
            { name: 'name', label: 'Name', type: 'string' },
            { name: 'category', label: 'Category', type: 'string' },
            { name: 'quantity', label: 'Quantity', type: 'number' },
            { name: 'unitPrice', label: 'Unit Price', type: 'number' },
            { name: 'totalValue', label: 'Total Value', type: 'number' },
            { name: 'supplierName', label: 'Supplier Name', type: 'string' },
            { name: 'lastUpdated', label: 'Last Updated', type: 'date' }
        ];
    }
}