import { Component, Input } from '@angular/core';
import { IMonsterAilment } from '../../../types/monsterTypes';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-monster-ailment',
  imports: [CommonModule],
  templateUrl: './monster-ailment.component.html',
  styleUrl: './monster-ailment.component.scss',
  standalone: true,
})
export class MonsterAilmentComponent {
  @Input() ailments!: IMonsterAilment[] | undefined;
}
