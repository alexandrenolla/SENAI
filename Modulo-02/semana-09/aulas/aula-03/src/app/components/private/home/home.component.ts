import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IFilme } from 'src/app/interfaces/IFilme';
import { ImdbService } from 'src/app/services/imdb.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
  // series = [
  //   { id: 1, nome: 'Constantine' },
  //   { id: 2, nome: 'Rome' },
  //   { id: 3, nome: 'Robot Chicken' },
  //   { id: 4, nome: 'True Detective' },
  //   { id: 5, nome: 'Sharp Objects' },
  //   { id: 6, nome: 'Marvel\'s Runaways' },
  //   { id: 7, nome: 'Atypical' },
  //   { id: 8, nome: 'Spartacus' },
  // ];

  filmes: IFilme[] = [];

  constructor(
    private router: Router, 
    private route: ActivatedRoute,
    private imdbService: ImdbService) { }

  ngOnInit(): void {
    this.imdbService.getFilmesMaisPopulares().subscribe(filmes => {
      this.filmes = filmes.items.slice(0, 8);
    });
  }

  recebeClickFilme(serie: IFilme) {
    this.router.navigate(
      [ '..', 'serie', serie.id], 
      { relativeTo: this.route }
    );
  }
}
