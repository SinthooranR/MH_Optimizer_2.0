import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonsterBreakComponent } from './monster-break.component';

describe('MonsterBreakComponent', () => {
  let component: MonsterBreakComponent;
  let fixture: ComponentFixture<MonsterBreakComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MonsterBreakComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MonsterBreakComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
