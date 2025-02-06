import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { MonstersPageComponent } from './pages/monsters-page/monsters-page.component';
import { EquipmentPageComponent } from './pages/equipment-page/equipment-page.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    CommonModule,
    MonstersPageComponent,
    EquipmentPageComponent,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent {
  title = 'Equipment_Optimizer_2.0';
}
