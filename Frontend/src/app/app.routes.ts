import { Routes } from '@angular/router';
import { MonstersPageComponent } from './pages/monsters-page/monsters-page.component';
import { EquipmentPageComponent } from './pages/equipment-page/equipment-page.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { MonsterDetailsPageComponent } from './pages/monster-details-page/monster-details-page.component';

export const routes: Routes = [
  {
    path: '',
    component: HomePageComponent,
    title: 'Home - MH Optimizer',
  },
  {
    path: 'monsters',
    component: MonstersPageComponent,
    title: 'Monsters Directory - MH Optimizer',
  },
  {
    path: 'monsters/:monsterName',
    component: MonsterDetailsPageComponent,
    title: 'Monster Details - MH Optimizer',
  },
  {
    path: 'equipment',
    component: EquipmentPageComponent,
    title: 'Equipment Directory - MH Optimizer',
  },
];
