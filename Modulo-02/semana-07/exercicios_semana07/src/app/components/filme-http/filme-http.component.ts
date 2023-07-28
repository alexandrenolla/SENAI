import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { IFilme } from 'src/app/interfaces/IFilme';
import { FilmesService } from 'src/app/services/filmes.service';

@Component({
  selector: 'app-filme-http',
  templateUrl: './filme-http.component.html',
  styleUrls: ['./filme-http.component.css']
})
export class FilmeHttpComponent {
  
  carregando = false;
  filmes: IFilme[] = [];
  filmeAtual: IFilme | null = null;
  filmesTopTres: IFilme[] | null =null;
  indiceFilme = 0;

  constructor(private filmesService: FilmesService) {
    this.filmesService.buscarFilmes().subscribe(resposta => {
      console.log(resposta);
      this.filmes = resposta;
      this.carregando = false;
      this.filmesTopTres = this.filmesService.BuscarTopTres(resposta);
      this.filmeAtual = this.filmesTopTres[0];
    });
   }

  buscarFilmes() {
    this.carregando = true;
  }

  filmeMelhorAvaliado() {
    const resultado = this.filmesService.buscarFilmeMelhorAvaliado(this.filmes);
    console.log(resultado);
  }

  Proximo() {
    this.indiceFilme++;
    if(this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }

  Anterior() {
    this.indiceFilme--;
    if(this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }

}
