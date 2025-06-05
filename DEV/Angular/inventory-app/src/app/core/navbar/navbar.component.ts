import { Component } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [
    CommonModule,
    MatToolbarModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatSlideToggleModule
  ],
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent {
  navLinks = [
    { path: '/inventory', label: 'Inventory' },
    { path: '/about', label: 'About' },
    { path: '/contact', label: 'Contact' }
  ];

  toggleDarkMode(isDark: boolean) {
    const html = document.documentElement;
    if (isDark) {
      html.classList.add('darkMode');
    } else {
      html.classList.remove('darkMode');
    }
  }
}