export class AsideSectionCollection {
    headerTitle: string;
    itemSectionTitle: string;
    itemsInside: AsideSectionItem[];
    
    constructor(headerTitle: string, itemSectionTitle: string, itemsInside: AsideSectionItem[]) {
        this.headerTitle = headerTitle;
        this.itemSectionTitle = itemSectionTitle;
        this.itemsInside = itemsInside;
    }
}

export class AsideSectionItem{
    name: string;
    nameIcon: string;
    order: number;
    link: string;

    constructor(name: string, nameIcon: string, order: number, link: string) {
        this.name = name;
        this.nameIcon = nameIcon;
        this.order = order;
        this.link = link;
    }
}