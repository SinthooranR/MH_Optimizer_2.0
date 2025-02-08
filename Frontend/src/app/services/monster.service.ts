import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import {} from '../types/apiTypes';
import { IMonster, IMonsterDetails } from '../types/monsterTypes';

@Injectable({
  providedIn: 'root',
})
export class MonsterService {
  constructor(private apiService: ApiService) {}

  getAllMonsters(url: string): Observable<IMonster[]> {
    return this.apiService.get(url, {});
  }

  getMonsterByName(url: string): Observable<IMonsterDetails> {
    return this.apiService.get(url, {});
  }
}
