import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonsterHitzoneComponent } from './monster-hitzone.component';

describe('MonsterHitzoneComponent', () => {
  let component: MonsterHitzoneComponent;
  let fixture: ComponentFixture<MonsterHitzoneComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MonsterHitzoneComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MonsterHitzoneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
