import { Component } from '@angular/core';
import { MonsterService } from '../../services/monster.service';
import { ActivatedRoute } from '@angular/router';
import { apiUrl } from '../../constants';
import { IMonsterDetails } from '../../types/monsterTypes';
import { CommonModule } from '@angular/common';
import { MonsterHabitatComponent } from '../../components/monster-details/monster-habitat/monster-habitat.component';

@Component({
  selector: 'app-monster-details-page',
  imports: [CommonModule, MonsterHabitatComponent],
  templateUrl: './monster-details-page.component.html',
  styleUrl: './monster-details-page.component.scss',
  standalone: true,
})
export class MonsterDetailsPageComponent {
  constructor(
    private monsterService: MonsterService,

    private activeRoute: ActivatedRoute
  ) {}
  monsterName: string = '';
  monsterDetails: Partial<IMonsterDetails> = {};

  getMonsterByName = () => {
    this.monsterService
      .getMonsterByName(`${apiUrl}/Monster/${this.monsterName}`)
      .subscribe((monsterData: IMonsterDetails) => {
        this.monsterDetails = monsterData;
        console.log(monsterData);
      });
  };

  ngOnInit(): void {
    this.monsterName = this.activeRoute.snapshot.params['monsterName'];

    if (this.monsterName) {
      this.getMonsterByName();
    }
  }
}
