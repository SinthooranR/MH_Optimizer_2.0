import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { ImageService } from '../../../services/image.service';
import { IMonsterHabitat } from '../../../types/monsterTypes';

@Component({
  selector: 'app-monster-habitat',
  imports: [CommonModule],
  templateUrl: './monster-habitat.component.html',
  styleUrl: './monster-habitat.component.scss',
})
export class MonsterHabitatComponent {
  constructor(private imageService: ImageService) {}

  @Input() habitat!: string;
  imageUrl = '';

  ngOnInit(): void {
    this.imageUrl = this.imageService.imageUrlFinder(this.habitat, [
      'assets/locations/ic_locations_coral_highlands.svg',
      'assets/locations/ic_locations_elders_recess.svg',
      'assets/locations/ic_locations_rotten_vale.svg',
      'assets/locations/ic_locations_wildspire_waste.svg',
      'assets/locations/ic_location_ancient_forest.svg',
    ]);
  }
}
