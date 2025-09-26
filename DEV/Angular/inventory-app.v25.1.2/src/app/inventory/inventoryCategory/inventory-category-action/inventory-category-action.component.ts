import { Component } from '@angular/core';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';
import { ActivatedRoute } from '@angular/router';
import { ActionButtonComponent } from "../../../core/common/controls/actions/action-button/action-button.component";
import { RegularActionCardTopComponent } from "../../../core/common/cards/regularActionCards/regular-action-card-top/regular-action-card-top.component";

@Component({
  selector: 'app-inventory-category-action',
  imports: [ActionButtonComponent, RegularActionCardTopComponent],
  templateUrl: './inventory-category-action.component.html',
  styleUrl: './inventory-category-action.component.scss'
})
export class InventoryCategoryActionComponent {
  constructor( 
    public gloablService: GlobalActionsService,
    private route: ActivatedRoute) { 

    }
}
