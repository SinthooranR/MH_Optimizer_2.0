import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-equipment-page',
  imports: [],
  templateUrl: './equipment-page.component.html',
  styleUrl: './equipment-page.component.scss',
  standalone: true,
})
export class EquipmentPageComponent {
  constructor(private route: ActivatedRoute) {}
  monsterName: string = '';

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      this.monsterName = params['monsterName'];
    });
  }
}
