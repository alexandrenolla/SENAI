import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  alunosPai: any[] = ['Emanuel', 'Rogério', 'Maria'];

  excluirAlunoDaListaPai(aluno: any) {
    console.log('excluirAlunoDaListaPai: ', aluno);

    const index = this.alunosPai.findIndex((alunoPai) => alunoPai === aluno);

    if (index != -1) {
      this.alunosPai.splice(index, 1);
    }
  }
}
