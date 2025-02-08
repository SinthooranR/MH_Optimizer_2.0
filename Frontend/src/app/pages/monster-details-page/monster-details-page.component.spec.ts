import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonsterDetailsPageComponent } from './monster-details-page.component';

describe('MonsterDetailsPageComponent', () => {
  let component: MonsterDetailsPageComponent;
  let fixture: ComponentFixture<MonsterDetailsPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MonsterDetailsPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MonsterDetailsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
