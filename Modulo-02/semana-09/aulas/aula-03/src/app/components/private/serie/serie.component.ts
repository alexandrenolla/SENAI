import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IFilme } from 'src/app/interfaces/IFilme';
import { ImdbService } from 'src/app/services/imdb.service';

@Component({
  selector: 'app-serie',
  templateUrl: './serie.component.html',
  styleUrls: ['./serie.component.css']
})
export class SerieComponent implements OnInit{

  filme: IFilme | null = null;

  constructor(private route: ActivatedRoute, private imdbService: ImdbService) { }

  ngOnInit(): void {
    const filmeId = this.route.snapshot.paramMap.get("id");
    if (filmeId === null) return;
    this.imdbService.getFilmeById(filmeId).subscribe(filme => this.filme = filme);
  }
}
