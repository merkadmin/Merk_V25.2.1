import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InventoryItemActionComponent } from './inventory-item-action.component';

describe('InventoryItemActionComponent', () => {
  let component: InventoryItemActionComponent;
  let fixture: ComponentFixture<InventoryItemActionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InventoryItemActionComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InventoryItemActionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
