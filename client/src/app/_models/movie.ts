export interface Movie {
  id: number;
  title: string;
  description: string;
  length: number;
  dateOfRelease: Date;
  trailerUrl: string;
  coverImageUrl: string;
  category: MovieCategory;
  playingDate: Date;
  playingTime: Date;
  image: string;
}

export enum MovieCategory {
  Horror = 1,
  Science_Fiction,
  Akcja,
  Przygodowy,
  Animowany,
  Komedia,
  Dramat,
  Thriller,
  Western,
  Historyczny
}

