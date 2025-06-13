import { Component, OnInit } from '@angular/core';
import { AsideSectionComponent } from './aside-section/aside-section.component';
import { AsideSectionItem } from './aside-section/AsideSectionItem';

@Component({
  selector: 'app-aside-nav-bar',
  imports: [AsideSectionComponent],
  templateUrl: './aside-nav-bar.component.html',
  styleUrl: './aside-nav-bar.component.scss',
})
export class AsideNavBarComponent implements OnInit {
  Settings_AsideSectionItem: AsideSectionItem = new AsideSectionItem(
    'Settings',
    'Inventory',
    [
      { name: 'Stores', nameIcon: 'bullet bullet-dot', order: 1 },
      { name: 'Categories', nameIcon: 'bullet bullet-dot', order: 2 },
      { name: 'Items', nameIcon: 'bullet bullet-dot', order: 3 },
    ]
  );

  ngOnInit(): void {
    if (this.Settings_AsideSectionItem?.itemsInside) {
      this.Settings_AsideSectionItem.itemsInside.sort((a, b) => a.order - b.order);
    }
  }
}
