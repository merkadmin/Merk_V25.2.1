import { IModel } from "./IModel";

export class Model implements IModel {
    IsOnDuty!: boolean;
    InsertedBy!: string;
    InsertedByName!: string;
    InsertedDate!: Date; 

}