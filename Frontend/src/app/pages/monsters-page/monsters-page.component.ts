import { Component } from '@angular/core';
import { MonsterService } from '../../services/monster.service';
import { CommonModule } from '@angular/common';
import { MonsterCardComponent } from '../../components/monster-card/monster-card.component';
import { apiUrl } from '../../constants';
import { IMonster } from '../../types/monsterTypes';
import { LoadSpinnerComponent } from '../../components/common/load-spinner/load-spinner.component';
import { delay } from 'rxjs';

@Component({
  selector: 'app-monsters-page',
  imports: [CommonModule, MonsterCardComponent, LoadSpinnerComponent],
  templateUrl: './monsters-page.component.html',
  styleUrl: './monsters-page.component.scss',
  standalone: true,
})
export class MonstersPageComponent {
  title = 'Monsters';
  monsters: IMonster[] = [];
  loading = true;

  constructor(private monsterService: MonsterService) {}

  getMonsters = () => {
    return this.monsterService
      .getAllMonsters(`${apiUrl}/Monster`)
      .pipe(delay(500))
      .subscribe({
        next: (data) => {
          this.monsters = data;
          this.loading = false;
        },
        error: (err) => {
          console.error('Error getting monsters', err);
          this.loading = false;
        },
      });
  };

  ngOnInit(): void {
    this.getMonsters();
  }
}
