import { AfterViewChecked, AfterViewInit, Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AsideSectionCollection } from './AsideSectionCollection';
import { RouterModule } from '@angular/router';
@Component({
  selector: 'app-aside-section',
  imports: 
  [
    CommonModule,
    RouterModule
  ],
  templateUrl: './aside-section.component.html',
  styleUrl: './aside-section.component.scss',
})
export class AsideSectionComponent implements AfterViewInit {
  @Input() AsideSectionItem: AsideSectionCollection | undefined;

  ngAfterViewInit(): void {
    console.log('AsideSectionItem:', this.AsideSectionItem);
  }
}
