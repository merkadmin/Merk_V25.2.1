import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InventoryCategoryActionComponent } from './inventory-category-action.component';

describe('InventoryCategoryActionComponent', () => {
  let component: InventoryCategoryActionComponent;
  let fixture: ComponentFixture<InventoryCategoryActionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InventoryCategoryActionComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InventoryCategoryActionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
