import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { Movie, MovieCategory } from '../../_models/movie';
import { MoviesService } from '../../_services/movies.service';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.css']
})
export class MovieDetailComponent implements OnInit {
  movie!: Movie;
  MovieCategory = MovieCategory;

  constructor(private moviesService: MoviesService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadMember();
  }

  loadMember() {
    this.moviesService.getMovie(Number(this.route.snapshot.paramMap.get('id'))).subscribe(movie => {
      this.movie = movie;
    })
  }

}
