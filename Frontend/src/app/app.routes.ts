import { Routes } from '@angular/router';
import { MonstersPageComponent } from './pages/monsters-page/monsters-page.component';
import { EquipmentPageComponent } from './pages/equipment-page/equipment-page.component';
import { HomePageComponent } from './pages/home-page/home-page.component';

export const routes: Routes = [
  { path: '', component: HomePageComponent },
  {
    path: 'monsters',
    component: MonstersPageComponent,
  },
  {
    path: 'equipment',
    component: EquipmentPageComponent,
  },
];
