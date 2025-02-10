import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MonsterAilmentComponent } from './monster-ailment.component';

describe('MonsterAilmentComponent', () => {
  let component: MonsterAilmentComponent;
  let fixture: ComponentFixture<MonsterAilmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MonsterAilmentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MonsterAilmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
