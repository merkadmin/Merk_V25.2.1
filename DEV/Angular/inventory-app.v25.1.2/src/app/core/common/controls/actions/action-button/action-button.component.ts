import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';

@Component({
  selector: 'app-action-button',
  imports: [RouterModule],
  templateUrl: './action-button.component.html',
  styleUrl: './action-button.component.scss'
})
export class ActionButtonComponent implements OnInit {
  @Input() class: string = 'btn btn-primary';
  @Input() icon: string = 'fa fa-plus';
  @Input() text: string = '';

  constructor(private route: ActivatedRoute) {

  }

  ngOnInit() {
    // const id = this.route.snapshot.paramMap.get('id');
    // console.log(id); // "2"
  }
}
