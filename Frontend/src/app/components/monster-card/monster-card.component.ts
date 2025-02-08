import { Component, Input } from '@angular/core';
import { IMonster } from '../../types/monsterTypes';

@Component({
  selector: 'app-monster-card',
  imports: [],
  templateUrl: './monster-card.component.html',
  styleUrl: './monster-card.component.scss',
  standalone: true,
})
export class MonsterCardComponent {
  @Input() monsterInfo!: IMonster;
  imageUrl: string = '';
  hrefUrl: string = '';

  ngOnInit() {
    // Set the imageUrl after the @Input() property is populated
    this.imageUrl = `assets/monster/${
      this.monsterInfo?.monsterId || 'default'
    }.png`;
    this.hrefUrl = `/monsters/${this.monsterInfo.name}`;
  }
}
