import { Component } from '@angular/core';
import { GlobalActionsService } from '../../../../../services/Generic/global-actions.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { ActionButtonComponent } from '../../../controls/actions/action-button/action-button.component';

@Component({
  selector: 'app-regular-card-action-top',
  imports: [
    ActionButtonComponent
  ],
  templateUrl: './regular-card-action-top.component.html',
  styleUrl: './regular-card-action-top.component.scss'
})
export class RegularCardActionTopComponent {
  constructor(
      public gloablService: GlobalActionsService,
      private spinner: NgxSpinnerService
    ) {}

    onRefreshData() {}
}
