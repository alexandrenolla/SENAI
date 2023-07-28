import { Component } from '@angular/core';

@Component({
  selector: 'fmt-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss'],
})
export class ListComponent {
  termoPesquisa = '';

  onClick() {
    alert('Botão clicado');
  }

  onMouseOver() {
    alert('MouseOver');
  }

  onMouseOut() {
    alert('MouseOut');
  }

  adicionarPessoa() {
    // processamento de adicionar uma pessoa
    console.log('adicionar pessoa');
  }

  onKeyUp(evento: any) {
    console.log(evento?.target?.value);

    this.termoPesquisa = evento?.target?.value;
  }
}
