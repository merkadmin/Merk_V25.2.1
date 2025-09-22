import { AfterViewInit, Component, CUSTOM_ELEMENTS_SCHEMA, OnDestroy, OnInit } from '@angular/core';
import { RegularListCardComponent } from '../../../core/common/cards/regularListCards/regular-list-card/regular-list-card.component';
import { CommonModule } from '@angular/common';
import { NgxSpinnerModule } from 'ngx-spinner';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-inventory-category-action',
  imports: [
    RegularListCardComponent,
    CommonModule,
    NgxSpinnerModule,
    RouterModule,
  ],
  templateUrl: './inventory-category-action.component.html',
  styleUrl: './inventory-category-action.component.scss',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class InventoryCategoryActionComponent implements OnInit, AfterViewInit, OnDestroy{
  ngOnInit(): void {}
  
  ngAfterViewInit(): void {}

  ngOnDestroy(): void {}

}
