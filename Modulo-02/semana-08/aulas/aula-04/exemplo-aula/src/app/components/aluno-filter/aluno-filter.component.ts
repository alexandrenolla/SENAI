import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-aluno-filter',
  templateUrl: './aluno-filter.component.html',
  styleUrls: ['./aluno-filter.component.scss'],
})
export class AlunoFilterComponent {
  @Input() nomeParaSerFiltrado = '';
  @Output() nomeParaSerFiltradoChange = new EventEmitter<string>();

  filtrar(filtro: string) {
    console.log('filtro: ', filtro);
    this.nomeParaSerFiltradoChange.emit(filtro);
  }
}
