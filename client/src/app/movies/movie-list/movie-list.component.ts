import { Component, OnInit } from '@angular/core';
import { Movie, MovieCategory } from '../../_models/movie';
import { MoviesService } from '../../_services/movies.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {
  movies: Movie[] = [];

  constructor(private moviesService: MoviesService) { }

  ngOnInit(): void {
    this.loadMembers();
  }

  loadMembers() {
    this.moviesService.getMovies().subscribe(movies => {
      this.movies = movies;
    })
  }

}
