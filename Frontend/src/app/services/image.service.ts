import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ImageService {
  constructor() {}
  // Ancient Forest
  // ic_location_ancient_forest.svg
  imageUrlFinder(name: string, urlList: string[]): string {
    const newName = name.toLowerCase().replaceAll(' ', '_');
    return urlList.find((url) => url.includes(newName)) as string;
  }
}
