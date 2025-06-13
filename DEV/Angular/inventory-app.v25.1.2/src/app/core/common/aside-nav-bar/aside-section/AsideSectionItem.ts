export class AsideSectionItem {
    headerTitle: string;
    itemSectionTitle: string;
    itemsInside: AsideSectionItemAttributes[];
    
    constructor(headerTitle: string, itemSectionTitle: string, itemsInside: AsideSectionItemAttributes[]) {
        this.headerTitle = headerTitle;
        this.itemSectionTitle = itemSectionTitle;
        this.itemsInside = itemsInside;
    }
}

export class AsideSectionItemAttributes{
    name: string;
    nameIcon: string;
    order: number;

    constructor(name: string, nameIcon: string, order: number) {
        this.name = name;
        this.nameIcon = nameIcon;
        this.order = order;
    }
}