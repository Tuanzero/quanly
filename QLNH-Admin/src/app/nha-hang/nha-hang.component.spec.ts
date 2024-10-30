import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NhaHangComponent } from './nha-hang.component';

describe('NhaHangComponent', () => {
  let component: NhaHangComponent;
  let fixture: ComponentFixture<NhaHangComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NhaHangComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NhaHangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
