import { Component, Input } from '@angular/core';
import { GlobalActionsService } from '../../../../../services/Generic/global-actions.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { ActionButtonComponent } from "../../../controls/actions/action-button/action-button.component";

@Component({
  selector: 'app-regular-list-card-top',
  imports: [
    ActionButtonComponent
  ],
  templateUrl: './regular-list-card-top.component.html',
  styleUrl: './regular-list-card-top.component.scss',
})
export class RegularListCardTopComponent {
  constructor(
    public gloablService: GlobalActionsService,
    private spinner: NgxSpinnerService
  ) {}

  onRefreshData() {}
}
