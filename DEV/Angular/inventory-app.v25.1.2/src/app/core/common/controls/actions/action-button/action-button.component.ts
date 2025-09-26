import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { GlobalActionsService } from '../../../../../services/Generic/global-actions.service';

@Component({
  selector: 'app-action-button',
  imports: [RouterModule],
  templateUrl: './action-button.component.html',
  styleUrl: './action-button.component.scss',
})
export class ActionButtonComponent implements OnInit {
  @Input() class: string = 'btn btn-primary';
  @Input() icon: string = 'fa fa-plus';
  @Input() text: string = '';

  constructor(
    private route: ActivatedRoute,
    public gloablService: GlobalActionsService,
    private router: Router
  ) {}

  ngOnInit() {
    // const id = this.route.snapshot.paramMap.get('id');
    // console.log(id); // "2"
  }

  onClick() {
    this.router.navigate(['/categoryaction', 0]);
  }
}
