import { Component, Input } from '@angular/core';
import { IMonsterHitzone } from '../../../types/monsterTypes';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-monster-hitzone',
  imports: [CommonModule],
  templateUrl: './monster-hitzone.component.html',
  styleUrl: './monster-hitzone.component.scss',
})
export class MonsterHitzoneComponent {
  @Input() hitzones!: IMonsterHitzone[] | undefined;
}
