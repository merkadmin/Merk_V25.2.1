import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PageCommonContolsComponent } from './page-common-contols.component';

describe('PageCommonContolsComponent', () => {
  let component: PageCommonContolsComponent;
  let fixture: ComponentFixture<PageCommonContolsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PageCommonContolsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PageCommonContolsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
