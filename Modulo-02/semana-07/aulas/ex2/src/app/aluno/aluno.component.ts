import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { IAluno } from '../interface/IAluno';

@Component({
  selector: 'app-aluno',
  templateUrl: './aluno.component.html',
  styleUrls: ['./aluno.component.css']
})
export class AlunoComponent {

  constructor (private mock:HttpClient) {}

  alunosCadastrados: IAluno[] = []

  onSubmit(alunoData: IAluno) {

    this.mock.post(`${environment.mockUrl}/alunos/register`, alunoData).subscribe((resultado) => {
      console.log(resultado);
    })

    console.log(alunoData);
  }

  buscarAlunos() {
    this.mock.get<IAluno[]>(`${environment.mockUrl}/alunos/get-all`)
    .subscribe((resultado) => {
      this.alunosCadastrados = resultado;
    })
  }
}
