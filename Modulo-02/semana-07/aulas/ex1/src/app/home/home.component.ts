import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  nome = 'Alexandre Henrique';
  idade = 28;
  desabilitarBotao = false;
  nome2: string = 'Maria Carolina'; //Declaraçào de variável no TypeScript.

  constructor() {
    console.log(`[INFO] Estou executando o constructor.`)
    this.trocarBotao();
  }

  trocarBotao() {
    setTimeout (() => {
      console.log(`[INFO] Estou trocando o estado do botão.`);
      this.desabilitarBotao = true;
    }, 5000)
  }

  botaoClicado() {
    console.log("Botão clicado.")
  }
}

