export class InventoryItems_TH {
  static readonly columns = [
    { name: 'id', label: 'ID', type: 'number' },
    { name: 'name', label: 'ชื่อสินค้า', type: 'string' },
    { name: 'category', label: 'หมวดหมู่', type: 'string' },
    { name: 'quantity', label: 'จำนวน', type: 'number' },
    { name: 'unitPrice', label: 'ราคาต่อหน่วย', type: 'number' },
    { name: 'totalValue', label: 'มูลค่ารวม', type: 'number' },
    { name: 'supplierName', label: 'ชื่อผู้จัดจำหน่าย', type: 'string' },
    { name: 'lastUpdated', label: 'วันที่ปรับปรุงล่าสุด', type: 'date' }
  ];
}