import { Component, OnInit } from '@angular/core';
import { AsideSectionComponent } from './aside-section/aside-section.component';
import { AsideSectionCollection } from './aside-section/AsideSectionCollection';

@Component({
  selector: 'app-aside-nav-bar',
  imports: [AsideSectionComponent],
  templateUrl: './aside-nav-bar.component.html',
  styleUrl: './aside-nav-bar.component.scss',
})
export class AsideNavBarComponent implements OnInit {
  Settings_AsideSectionItem: AsideSectionCollection = new AsideSectionCollection(
    'Settings',
    'bi bi-archive fs-3',
    'Inventory',
    '',
    [
      { name: 'Stores', nameIcon: 'bullet bullet-dot', order: 1, link: 'settings/stores' },
      { name: 'Categories', nameIcon: 'bullet bullet-dot', order: 2, link: 'settings/categories' },
      { name: 'Items', nameIcon: 'bullet bullet-dot', order: 3, link: 'settings/items' },
    ]
  );

  ngOnInit(): void {
    if (this.Settings_AsideSectionItem?.itemsInside) {
      this.Settings_AsideSectionItem.itemsInside.sort((a, b) => a.order - b.order);
    }
  }
}
