import { Component } from '@angular/core';
import { GlobalActionsService } from '../../../services/Generic/global-actions.service';
import { ActivatedRoute } from '@angular/router';
import { ActionButtonComponent } from "../../../core/common/controls/actions/action-button/action-button.component";

@Component({
  selector: 'app-inventory-category-action',
  imports: [ActionButtonComponent],
  templateUrl: './inventory-category-action.component.html',
  styleUrl: './inventory-category-action.component.scss'
})
export class InventoryCategoryActionComponent {
  constructor( 
    public gloablService: GlobalActionsService,
    private route: ActivatedRoute) { 

    }
}
