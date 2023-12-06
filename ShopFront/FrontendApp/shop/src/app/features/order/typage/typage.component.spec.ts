import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TypageComponent } from './typage.component';

describe('TypageComponent', () => {
  let component: TypageComponent;
  let fixture: ComponentFixture<TypageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TypageComponent]
    });
    fixture = TestBed.createComponent(TypageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
