import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InventoryStoresListComponent } from './inventory-stores-list.component';

describe('InventoryStoresListComponent', () => {
  let component: InventoryStoresListComponent;
  let fixture: ComponentFixture<InventoryStoresListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InventoryStoresListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InventoryStoresListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
