import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonsterWeaknessComponent } from './monster-weakness.component';

describe('MonsterWeaknessComponent', () => {
  let component: MonsterWeaknessComponent;
  let fixture: ComponentFixture<MonsterWeaknessComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MonsterWeaknessComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MonsterWeaknessComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
