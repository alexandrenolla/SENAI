import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { IFilme } from '../interfaces/IFilme';

@Injectable({
  providedIn: 'root'
})
export class ImdbService {

  constructor(private httpClient: HttpClient) { }

  getFilmesMaisPopulares() {
    const url = `${environment.endpoint}/en/API/MostPopularMovies/${environment.apiKey}`;
    return this.httpClient.get<{ items: IFilme[], errorMessage: string }>(url);
  }

  getFilmeById(id: string) {
    const url = `${environment.endpoint}/en/API/Title/${environment.apiKey}/${id}`;
    return this.httpClient.get<IFilme>(url);
  }
}
