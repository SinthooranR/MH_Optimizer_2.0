import { Component, Input, SimpleChanges } from '@angular/core';
import { Monster } from '../../types';

@Component({
    selector: 'app-monster-card',
    imports: [],
    templateUrl: './monster-card.component.html',
    styleUrl: './monster-card.component.scss'
})
export class MonsterCardComponent {
  @Input() monsterInfo!: Monster;
  imageUrl: string = '';

  ngOnInit() {
    // Set the imageUrl after the @Input() property is populated
    this.imageUrl = `assets/monster/${
      this.monsterInfo?.monsterId || 'default'
    }.png`;
  }
}
