import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InventoryStoreActionComponent } from './inventory-store-action.component';

describe('InventoryStoreActionComponent', () => {
  let component: InventoryStoreActionComponent;
  let fixture: ComponentFixture<InventoryStoreActionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InventoryStoreActionComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InventoryStoreActionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
