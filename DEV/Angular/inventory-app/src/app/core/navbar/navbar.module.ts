import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar.component';

@NgModule({
  imports: [
    CommonModule,
    NavbarComponent,
  ],
  exports: [NavbarComponent]
})
export class NavbarModule { }