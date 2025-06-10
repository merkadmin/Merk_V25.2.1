import { NgModule } from '@angular/core';
import { AsideNavBarComponent } from './aside-nav-bar/aside-nav-bar.component';
import { HeaderControlsComponent } from './header-controls/header-controls.component';


@NgModule({
  declarations: [],
  imports: [
    AsideNavBarComponent,
    HeaderControlsComponent
  ],
  exports: [
    AsideNavBarComponent,
    HeaderControlsComponent
  ],
})
export class CommonModule { }
