import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AsideSectionCollection } from './AsideSectionCollection';
@Component({
  selector: 'app-aside-section',
  imports: 
  [
    CommonModule 
  ],
  templateUrl: './aside-section.component.html',
  styleUrl: './aside-section.component.scss',
})
export class AsideSectionComponent {
  @Input() AsideSectionItem: AsideSectionCollection | undefined;
}
