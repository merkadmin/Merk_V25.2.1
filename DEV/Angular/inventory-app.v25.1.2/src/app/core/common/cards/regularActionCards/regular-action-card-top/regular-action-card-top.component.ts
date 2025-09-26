import { Component } from '@angular/core';
import { GlobalActionsService } from '../../../../../services/Generic/global-actions.service';

@Component({
  selector: 'app-regular-action-card-top',
  imports: [],
  templateUrl: './regular-action-card-top.component.html',
  styleUrl: './regular-action-card-top.component.scss'
})
export class RegularActionCardTopComponent {


  constructor(
    public gloablService: GlobalActionsService) {

  }
}
