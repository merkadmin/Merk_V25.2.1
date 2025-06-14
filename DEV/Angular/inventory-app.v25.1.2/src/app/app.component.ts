import { AfterViewInit, Component, OnChanges, SimpleChanges } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AsideNavBarComponent } from "./core/common/aside-nav-bar/aside-nav-bar.component";
import { HeaderControlsComponent } from './core/common/header-controls/header-controls.component';
// declare const KTMenu: any;

@Component({
  selector: 'app-root',
  imports: [
    RouterOutlet,
    AsideNavBarComponent,
    HeaderControlsComponent
],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements AfterViewInit, OnChanges {
  title: string = 'Inventory App';

   ngAfterViewInit(): void {
    // if (typeof KTMenu !== 'undefined') {
    //   KTMenu.createInstances();
    // }
  }

  ngOnChanges(changes: SimpleChanges): void {
    // if (typeof KTMenu !== 'undefined') {
    //   setTimeout(() => KTMenu.createInstances(), 0);
    // }
  }
}
