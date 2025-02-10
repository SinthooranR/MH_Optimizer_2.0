import { Component } from '@angular/core';
import { MonsterService } from '../../services/monster.service';
import { ActivatedRoute } from '@angular/router';
import { apiUrl } from '../../constants';
import { IMonsterDetails } from '../../types/monsterTypes';
import { CommonModule } from '@angular/common';
import { MonsterHabitatComponent } from '../../components/monster-details/monster-habitat/monster-habitat.component';
import { MonsterWeaknessComponent } from '../../components/monster-details/monster-weakness/monster-weakness.component';
import { MonsterBreakComponent } from '../../components/monster-details/monster-break/monster-break.component';
import { MonsterHitzoneComponent } from '../../components/monster-details/monster-hitzone/monster-hitzone.component';
import { MonsterAilmentComponent } from '../../components/monster-details/monster-ailment/monster-ailment.component';
import { MonsterRewardComponent } from '../../components/monster-details/monster-reward/monster-reward.component';

@Component({
  selector: 'app-monster-details-page',
  imports: [
    CommonModule,
    MonsterHabitatComponent,
    MonsterWeaknessComponent,
    MonsterBreakComponent,
    MonsterHitzoneComponent,
    MonsterAilmentComponent,
    MonsterRewardComponent,
  ],
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
