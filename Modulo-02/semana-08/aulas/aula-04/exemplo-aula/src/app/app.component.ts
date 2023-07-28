import { Component } from '@angular/core';
import { ALUNOS_MOCK } from './constants/pessoas';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  nomeParaSerFiltrado = 'kELVIS';

  alunosPai: any[] = ALUNOS_MOCK;

  excluirAlunoDaListaPai(aluno: any) {
    console.log('excluirAlunoDaListaPai: ', aluno);

    const index = this.alunosPai.findIndex((alunoPai) => alunoPai === aluno);

    if (index != -1) {
      this.alunosPai.splice(index, 1);
    }
  }
}
