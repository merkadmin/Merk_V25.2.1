import { Model } from "./Model";

export class InventoryCategoryModel extends Model {
    EntityID: number | undefined;
    CategoryName_P: string | undefined;
    CategoryName_S: string | undefined;
    CategoryInternalCode: string | undefined;
    CategoryDescription: string | undefined;
}