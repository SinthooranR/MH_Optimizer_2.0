import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonsterHabitatComponent } from './monster-habitat.component';

describe('MonsterHabitatComponent', () => {
  let component: MonsterHabitatComponent;
  let fixture: ComponentFixture<MonsterHabitatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MonsterHabitatComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MonsterHabitatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
