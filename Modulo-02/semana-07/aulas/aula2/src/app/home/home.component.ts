import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  datasDeClique: any[] = [];
  exibirValor = true;

  alunosTypeScript = [
    {
      nome: 'Bruno',
      nota: 80,
      exibir: true
    },
    {
      nome: 'Bianca',
      nota: 95,
      exibir: true
    },
    {
      nome: 'Reinanldo',
      nota: 70,
      exibir: true
    },
  ];

  listaDeCompras = [
    'Cenoura',
    'Batata',
    'Gergelim',
    'Abacate',
    'Leite',
    'Orégano'
  ];

  exibirAluno() {
    return false;
  }

  emCliqueBotao() {
    const dataClique = {
      data: Date.now(),
      exibir: this.exibirValor
    };
    
    this.exibirValor = !this.exibirValor;
    this.datasDeClique.push(dataClique);
  }
}
