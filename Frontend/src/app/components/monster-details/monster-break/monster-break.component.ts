import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { IMonsterBreak } from '../../../types/monsterTypes';

@Component({
  selector: 'app-monster-break',
  imports: [CommonModule],
  templateUrl: './monster-break.component.html',
  styleUrl: './monster-break.component.scss',
})
export class MonsterBreakComponent {
  @Input() breaks!: IMonsterBreak[] | undefined;
}
