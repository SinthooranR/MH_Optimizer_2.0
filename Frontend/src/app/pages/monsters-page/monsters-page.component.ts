import { Component } from '@angular/core';
import { MonsterService } from '../../services/monster.service';
import { CommonModule } from '@angular/common';
import { MonsterCardComponent } from '../../components/monster-card/monster-card.component';
import { apiUrl } from '../../constants';
import { IMonster } from '../../types/monsterTypes';

@Component({
  selector: 'app-monsters-page',
  imports: [CommonModule, MonsterCardComponent],
  templateUrl: './monsters-page.component.html',
  styleUrl: './monsters-page.component.scss',
  standalone: true,
})
export class MonstersPageComponent {
  title = 'Monsters';
  monsters: IMonster[] = [];

  constructor(private monsterService: MonsterService) {}

  getMonsters = () => {
    return this.monsterService
      .getAllMonsters(`${apiUrl}/Monster`)
      .subscribe((monsters: IMonster[]) => {
        this.monsters = monsters;
      });
  };

  ngOnInit(): void {
    this.getMonsters();
  }
}
