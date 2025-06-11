import { NgModule } from '@angular/core';
import { AsideNavBarComponent } from './aside-nav-bar/aside-nav-bar.component';
import { HeaderControlsComponent } from './header-controls/header-controls.component';
import { SearchInputComponent } from './controls/inputs/search-input/search-input.component';


@NgModule({
  declarations: [],
  imports: [
    AsideNavBarComponent,
    HeaderControlsComponent,
    SearchInputComponent
  ],
  exports: [
    SearchInputComponent
  ],
})
export class CommonModule { }
