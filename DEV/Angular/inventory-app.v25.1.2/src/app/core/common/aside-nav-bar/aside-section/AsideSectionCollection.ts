export class AsideSectionCollection {
    headerTitle: string;
    headerTitleIcon: string;
    itemSectionTitle: string;
    itemSectionLink: string;
    isActive: boolean;
    itemsInside: AsideSectionItem[];
    
    constructor(headerTitle: string, headerTitleIcon: string, itemSectionTitle: string, itemSectionLink: string, isActive: boolean, itemsInside: AsideSectionItem[]) {
        this.headerTitle = headerTitle;
        this.headerTitleIcon = headerTitleIcon;
        this.itemSectionTitle = itemSectionTitle;
        this.itemSectionLink = itemSectionLink;
        this.isActive = isActive;
        this.itemsInside = itemsInside;
    }
}

export class AsideSectionItem{
    name: string;
    nameIcon: string;
    order: number;
    link: string;
    isActive: boolean;

    constructor(name: string, nameIcon: string, order: number, link: string, isActive: boolean = false) {
        this.name = name;
        this.nameIcon = nameIcon;
        this.order = order;
        this.link = link;
        this.isActive = isActive;
    }
}