export interface IMonster {
  id: number;
  monsterId: number;
  name: string;
  ecology?: string;
  size: string;
  pitfallTrap?: string;
  shockTrap?: string;
  vineTrap?: string;
  description?: string;
}

//

export interface IMonsterDetails {
  monster: IMonster;
  monster_Ailments: IMonsterAilment[];
  monster_Weaknesses: IMonsterWeakness[];
  monster_Breaks: IMonsterBreak[];
  monster_Hitzones: IMonsterHitzone[];
  monster_Rewards: IMonsterRewards[];
  monster_Habitats: IMonsterHabitat[];
}

export interface IMonsterAilment {
  id: number;
  name: string;
  roar: string;
  wind: string;
  tremor: string;
  defenseDown: string;
  fireblight: string;
  waterblight: string;
  thunderblight: string;
  iceblight: string;
  dragonblight: string;
  blastblight: string;
  regional: string;
  poison: string;
  sleep: string;
  paralysis: string;
  bleed: string;
  stun: string;
  mud: string;
  effluvia: string;
}

export interface IMonsterWeakness {
  id: number;
  name: string;
  form: string;
  altDescription: string;
  fire: string;
  water: string;
  thunder: string;
  ice: string;
  dragon: string;
  poison: string;
  sleep: string;
  paralysis: string;
  blast: string;
  stun: string;
}

export interface IMonsterBreak {
  id: number;
  name: string;
  part: string;
  partJa: string;
  flinch: string;
  wound: string;
  sever: string;
  extract: string;
}

export interface IMonsterHitzone {
  id: number;
  name: string;
  hitzone: string;
  cut: string;
  impact: string;
  shot: string;
  fire: string;
  water: string;
  thunder: string;
  ice: string;
  dragon: string;
  ko: string;
}

export interface IMonsterRewards {
  id: number;
  name: string;
  rank: string;
  condition: string;
  item: string;
  stack: number;
  percentage: number;
}

export interface IMonsterHabitat {
  id: number;
  name: string;
  map: string;
  startArea: string;
  moveArea: string;
  restArea: string;
}
