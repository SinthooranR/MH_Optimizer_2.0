import { Component, Input } from '@angular/core';
import { Monster } from '../../types';

@Component({
  selector: 'app-monster-card',
  standalone: true,
  imports: [],
  templateUrl: './monster-card.component.html',
  styleUrl: './monster-card.component.scss',
})
export class MonsterCardComponent {
  @Input() monsterInfo!: Monster;
}
