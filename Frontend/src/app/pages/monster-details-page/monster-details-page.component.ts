import { Component } from '@angular/core';
import { MonsterService } from '../../services/monster.service';
import { ActivatedRoute, ActivatedRouteSnapshot } from '@angular/router';
import { apiUrl } from '../../constants';
import { IMonsterDetails } from '../../types/monsterTypes';

@Component({
  selector: 'app-monster-details-page',
  imports: [],
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
  getAllMonsters = () => {
    this.monsterService
      .getMonsterByName(`${apiUrl}/Monster/${this.monsterName}`)
      .subscribe((monsterDetails: IMonsterDetails) => {
        console.log(monsterDetails);
      });
  };

  ngOnInit(): void {
    this.monsterName = this.activeRoute.snapshot.params['monsterName'];

    if (this.monsterName) {
      this.getAllMonsters();
    }
  }
}
