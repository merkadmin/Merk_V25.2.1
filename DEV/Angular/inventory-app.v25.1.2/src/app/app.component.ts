import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AsideNavBarComponent } from "./core/common/aside-nav-bar/aside-nav-bar.component";
import { HeaderControlsComponent } from './core/common/header-controls/header-controls.component';

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
export class AppComponent {
  title: string = 'Inventory App';
}
