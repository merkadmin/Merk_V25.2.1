import { Model } from "./Model";

export class InventoryCategoryModel extends Model {
    EntityID: number | undefined;
    NameP: string | undefined;
    NameS: string | undefined;
    InternalCode: string | undefined;
    Description: string | undefined;
}