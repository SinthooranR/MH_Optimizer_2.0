import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonsterRewardComponent } from './monster-reward.component';

describe('MonsterRewardComponent', () => {
  let component: MonsterRewardComponent;
  let fixture: ComponentFixture<MonsterRewardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MonsterRewardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MonsterRewardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
