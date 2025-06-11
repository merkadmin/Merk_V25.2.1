import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-action-button',
  imports: [],
  templateUrl: './action-button.component.html',
  styleUrl: './action-button.component.scss'
})
export class ActionButtonComponent {
  @Input() class: string = 'btn btn-primary';
  @Input() icon: string = 'fa fa-plus';
  @Input() text: string = '---';
}
