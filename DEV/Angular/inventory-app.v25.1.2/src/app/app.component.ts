import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AsideNavBarComponent } from "./core/common/aside-nav-bar/aside-nav-bar.component";
import { HeaderControlsComponent } from './core/common/header-controls/header-controls.component';
import { InventoryModule } from './inventory/inventory.module';
import { SearchInputComponent } from './core/common/controls/inputs/search-input/search-input.component';

@Component({
  selector: 'app-root',
  imports: [
    RouterOutlet,
    AsideNavBarComponent,
    HeaderControlsComponent,
    InventoryModule
],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title: string = 'Inventory App';
}
