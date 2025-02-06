import { Component } from '@angular/core';
import { Monster } from '../../types';
import { MonsterService } from '../../services/monster.service';
import { CommonModule } from '@angular/common';
import { MonsterCardComponent } from '../../components/monster-card/monster-card.component';
import { apiUrl } from '../../constants';

@Component({
  selector: 'app-monsters-page',
  standalone: true,
  imports: [CommonModule, MonsterCardComponent],
  templateUrl: './monsters-page.component.html',
  styleUrl: './monsters-page.component.scss',
})
export class MonstersPageComponent {
  title = 'Monsters';
  monsters: Monster[] = [];

  constructor(private monsterService: MonsterService) {}

  getMonsters = () => {
    return this.monsterService
      .get(`${apiUrl}/Monster`)
      .subscribe((monsters: Monster[]) => {
        this.monsters = monsters;
      });
  };

  ngOnInit(): void {
    this.getMonsters();
  }
}
