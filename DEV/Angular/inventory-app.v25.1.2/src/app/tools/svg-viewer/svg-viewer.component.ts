import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import svgFiles from '../../../assets/media/icons/duotune/svg-list.json';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-svg-viewer',
  imports: 
  [
    CommonModule,
    FormsModule
  ],
  templateUrl: './svg-viewer.component.html',
  styleUrl: './svg-viewer.component.scss',
})
export class SvgViewerComponent {
  svgFiles: string[] = svgFiles;
  searchText: string = '';

  getIconPath(file: string): string {
    return `assets/media/icons/duotune/${file}`;
  }

  get filteredSvgFiles(): string[] {
    if (!this.searchText) return this.svgFiles;
    return this.svgFiles.filter((file) =>
      file.toLowerCase().includes(this.searchText.toLowerCase())
    );
  }
}
