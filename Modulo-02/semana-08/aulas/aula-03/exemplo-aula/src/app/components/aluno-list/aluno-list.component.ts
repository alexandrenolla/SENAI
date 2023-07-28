import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-aluno-list',
  templateUrl: './aluno-list.component.html',
  styleUrls: ['./aluno-list.component.scss'],
})
export class AlunoListComponent {
  // @Input('alunosFilhos')
  // alunos: any[] = [];

  @Input()
  alunosFilhos: any[] = [];

  @Output()
  alunoExcluido = new EventEmitter<any>();

  excluirAluno(aluno: any) {
    // emitir evento
    this.alunoExcluido.emit(aluno);
  }
}
