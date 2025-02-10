import { Component, Input } from '@angular/core';
import { IMonsterWeakness } from '../../../types/monsterTypes';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-monster-weakness',
  imports: [CommonModule],
  templateUrl: './monster-weakness.component.html',
  styleUrl: './monster-weakness.component.scss',
})
export class MonsterWeaknessComponent {
  @Input() weaknesses!: IMonsterWeakness[] | undefined;

  weaknessTypes: { key: keyof IMonsterWeakness; label: string }[] = [
    { key: 'fire', label: 'Fire' },
    { key: 'water', label: 'Water' },
    { key: 'thunder', label: 'Thunder' },
    { key: 'ice', label: 'Ice' },
    { key: 'dragon', label: 'Dragon' },
    { key: 'poison', label: 'Poison' },
    { key: 'sleep', label: 'Sleep' },
    { key: 'paralysis', label: 'Paralysis' },
    { key: 'blast', label: 'Blast' },
    { key: 'stun', label: 'Stun' },
  ];

  getWeaknessArray(
    weakness: IMonsterWeakness,
    type: keyof IMonsterWeakness
  ): any[] {
    return new Array(weakness[type]);
  }
}
