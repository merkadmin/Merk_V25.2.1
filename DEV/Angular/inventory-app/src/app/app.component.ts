import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarModule } from "./core/navbar/navbar.module";
import { NavbarComponent } from "./core/navbar/navbar.component";
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [
    RouterOutlet,
     NavbarModule, 
     NavbarComponent,
    ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'inventory-app';

  events: string[] = [];
  opened: boolean = true;

  shouldRun = /(^|.)(stackblitz|webcontainer).(io|com)$/.test(window.location.host);
}
