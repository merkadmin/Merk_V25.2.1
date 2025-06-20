import { Model } from "./Model";

export class InventoryStoreModel extends Model {
    EntityID: number | undefined;
    NameP: string | undefined;
    NameS: string | undefined;
    InternalCode: string | undefined;
    ParentStoreID: number | undefined;
    ParentStoreName: string | undefined;
    IsMain: boolean | undefined;
    Description: string | undefined;
}