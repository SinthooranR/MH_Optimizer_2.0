import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { Monster } from '../types';

@Injectable({
  providedIn: 'root',
})
export class MonsterService {
  constructor(private apiService: ApiService) {}

  get(url: string): Observable<Monster[]> {
    return this.apiService.get(url, {});
  }
}
