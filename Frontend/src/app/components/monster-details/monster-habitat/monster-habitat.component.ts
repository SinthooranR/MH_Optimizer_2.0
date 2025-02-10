import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { ImageService } from '../../../services/image.service';
import { IMonsterHabitat } from '../../../types/monsterTypes';
import { habitatUrls } from '../../../constants';

@Component({
  selector: 'app-monster-habitat',
  imports: [CommonModule],
  templateUrl: './monster-habitat.component.html',
  styleUrl: './monster-habitat.component.scss',
})
export class MonsterHabitatComponent {
  constructor(private imageService: ImageService) {}

  @Input() habitats!: IMonsterHabitat[] | undefined;
  imageUrls: string[] = [];

  ngOnChanges(): void {
    if (this.habitats) {
      this.imageUrls = this.habitats.map((habitat) =>
        this.imageService.imageUrlFinder(habitat.map, habitatUrls)
      );
    }
  }
}
