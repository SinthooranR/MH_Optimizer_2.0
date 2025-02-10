import { Component, Input } from '@angular/core';
import { IMonsterReward } from '../../../types/monsterTypes';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-monster-reward',
  imports: [CommonModule],
  templateUrl: './monster-reward.component.html',
  styleUrl: './monster-reward.component.scss',
})
export class MonsterRewardComponent {
  @Input() rewards!: IMonsterReward[] | undefined;
}
