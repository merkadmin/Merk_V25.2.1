import { Component, OnInit } from '@angular/core';
import { AsideSectionComponent } from './aside-section/aside-section.component';
import { AsideSectionCollection } from './aside-section/AsideSectionCollection';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';
import { CommonModule } from '@angular/common';
import { AsideNavBarService } from '../../../services/Generic/aside-nav-bar.service';

@Component({
  selector: 'app-aside-nav-bar',
  imports: 
  [
    AsideSectionComponent,
    CommonModule
  ],
  templateUrl: './aside-nav-bar.component.html',
  styleUrl: './aside-nav-bar.component.scss',
})
export class AsideNavBarComponent implements OnInit {
  Settings_AsideSectionItem: AsideSectionCollection | undefined;

  constructor(
    private globalActionsService: GlobalActionsService,
    public asideNavBarService: AsideNavBarService
  ) {
    this.asideNavBarService.setAsideNavBarItems();
  }


  ngOnInit(): void {
    this.asideNavBarService.AsideItems.forEach((item) => {
      item.itemsInside?.sort((a, b) => a.order - b.order);
    });
  }
}
