export class AsideSectionCollection {
    headerTitle: string;
    headerTitleIcon: string;
    itemSectionTitle: string;
    itemSectionLink: string;
    itemsInside: AsideSectionItem[];
    
    constructor(headerTitle: string, headerTitleIcon: string, itemSectionTitle: string, itemSectionLink: string, itemsInside: AsideSectionItem[]) {
        this.headerTitle = headerTitle;
        this.headerTitleIcon = headerTitleIcon;
        this.itemSectionTitle = itemSectionTitle;
        this.itemSectionLink = itemSectionLink;
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