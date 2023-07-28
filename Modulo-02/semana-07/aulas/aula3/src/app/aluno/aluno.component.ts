import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Component } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { IAluno } from '../interfaces/IAluno';

@Component({
  selector: 'app-aluno',
  templateUrl: './aluno.component.html',
  styleUrls: ['./aluno.component.css']
})
export class AlunoComponent {

  alunosCadastrados: IAluno[] = []

  constructor(private httpClient: HttpClient) { }

  onSubmit(alunoData: IAluno) {
    this.httpClient.post(`${environment.mockUrl}/alunos/register`, alunoData).subscribe((resultado) => {
      console.log(resultado);
    });
  }

  buscarAlunos() {
    this.httpClient.get<IAluno[]>(`${environment.mockUrl}/alunos/get-all/get`)
    .subscribe({
      next: resposta => this.alunosCadastrados = resposta,
      error: (erro: HttpErrorResponse) => {
        console.log('houve um erro!!');
        console.log(erro.status);
        console.log(erro.message);
      }
    });
  }
}
