import { Component, Input } from '@angular/core';
import { IMonsterAilment } from '../../../types/monsterTypes';

@Component({
  selector: 'app-monster-ailment',
  imports: [],
  templateUrl: './monster-ailment.component.html',
  styleUrl: './monster-ailment.component.scss',
  standalone: true,
})
export class MonsterAilmentComponent {
  @Input() monsterAilment!: IMonsterAilment;
}
