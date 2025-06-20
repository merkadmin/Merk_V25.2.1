import { Injectable } from '@angular/core';
import { AsideSectionCollection } from '../../core/common/aside-nav-bar/aside-section/AsideSectionCollection';

@Injectable({
  providedIn: 'root',
})
export class AsideNavBarService {
  private _asideItems: AsideSectionCollection[] =[] as AsideSectionCollection[];
  get AsideItems(): AsideSectionCollection[] {
    return this._asideItems;
  }
  set AsideItems(value: AsideSectionCollection[]) {
    this._asideItems = value;
  }

  constructor() {}

  setAsideNavBarItems() {
    this.AsideItems = [
      {
        headerTitle: 'Settings',
        headerTitleIcon: 'bi bi-archive fs-3', // Using 'icon' property as seen in AsideSectionCollection structure
        itemSectionTitle: 'Inventory',
        itemSectionLink: '', // Link for the section itself, often empty if it's just a header
        itemsInside: [
          {
            name: 'Stores',
            nameIcon: 'bullet bullet-dot',
            order: 2,
            link: 'stores',
          },
          {
            name: 'Categories',
            nameIcon: 'bullet bullet-dot',
            order: 1,
            link: 'categories',
          },
          {
            name: 'Items',
            nameIcon: 'bullet bullet-dot',
            order: 3,
            link: 'items',
          },
        ],
      },
    ];
  }
}
