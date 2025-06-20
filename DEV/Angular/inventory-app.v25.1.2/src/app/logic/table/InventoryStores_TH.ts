import { TableHeader } from "./TableHeader";

export class InventoryStores_TH extends TableHeader {
    constructor() {
        super();
        this.tableHeaders = [
            { name: 'InternalCode', label: 'Code', type: 'string' },
            { name: 'NameP', label: 'Name', type: 'string' },
            { name: 'ParentStoreName', label: 'Parent Store', type: 'string' },
            { name: 'IsMain', label: 'Main', type: 'boolean' }, 
            { name: 'Description', label: 'Description', type: 'string' }
        ];
    }
}