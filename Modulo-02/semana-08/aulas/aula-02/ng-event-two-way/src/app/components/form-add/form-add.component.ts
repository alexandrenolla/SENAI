import { Component } from '@angular/core';

@Component({
  selector: 'fmt-form-add',
  template: `
    <div>
      <h1>Two way data binding</h1>
      <!-- Informe o nome: -->
      <!-- <input [(ngModelChange)]="atualizarNome($event)"
      /> -->
      <!-- <input [ngModel]="name"
            (ngModelChange)="atualizarNome($event)"
      /> -->
      Filtrar:
      <input type="search" [(ngModel)]="name" (ngModelChange)="(name)" />
    </div>
    <br />
    <div>Valor informado é: {{ name }}</div>
    <div>Valor informado de filtro: {{ nameFiltered }}</div>
  `,
  styleUrls: ['./form-add.component.scss'],
})
export class FormAddComponent {
  name = 'Kelvis';
  nameFiltered = '';

  // atualizarNome(evento: any) {
  //   this.name = evento;
  // }
  filtro(evento: any) {
    let pessoaFiltrada = evento.toLowerCase();

    let pessoas = ['Emanuel', 'Maria', 'Kelvis'];

    pessoas.find((pessoa) => pessoa.toLowerCase() === pessoaFiltrada);
  }
}
