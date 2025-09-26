export enum Application{
    InventoryCategoryList,
    InventoryCategoryAction,
    InventoryStoresList,
}

export enum ActionType {
  AddNew = 'AddNew',
  List = 'List',
  Edit = 'Edit',
  Delete = 'Delete',
  Save = 'Save',
  Cancel = 'Cancel',
  Refresh = 'Refresh'
}

export class ActionTypeConstructor {
  ActionType: ActionType | undefined;
  RouteLink: string | undefined;
}