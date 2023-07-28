import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { IFilme } from '../interfaces/IFilme';

@Injectable({
  providedIn: 'root'
})
export class FilmesService {

  constructor(private HttpClient: HttpClient) { }

  buscarFilmes() {
    return this.HttpClient.get<IFilme[]>(`${environment.apiUrl}/filmes/get-all`)
  }

  buscarFilmeMelhorAvaliado(filmes: IFilme[]) {
    return filmes.reduce(function(filmePrev, filmeAtual) {
      return filmePrev.notaIMDb > filmeAtual.notaIMDb? filmePrev : filmeAtual;
    })
  }

  BuscarTopTres(filmes:IFilme[]) {
    let filmesCopia: IFilme[] = filmes;
    let topTres: IFilme[] = [];

    for(let i = 0; i < 3; i++) {
      topTres.push(this.buscarFilmeMelhorAvaliado(filmesCopia))
      filmesCopia.splice(filmesCopia.indexOf(topTres[i]), 1);
    }

    return topTres;
  }
}
