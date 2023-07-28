import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  primeiroNumero = 0;
  segundoNumero = 0;
  resultado = 0;
  operacao = 'soma';

  textoDigitado = 'Valor inicial';

  calcular() {
    switch (this.operacao) {
      case 'soma':
        this.resultado = this.primeiroNumero + this.segundoNumero;
        break;
      case 'subtracao':
        this.resultado = this.primeiroNumero - this.segundoNumero;
        break;
      case 'multiplicacao':
        this.resultado = this.primeiroNumero * this.segundoNumero;
        break;
      case 'divisao':
        this.resultado = this.primeiroNumero / this.segundoNumero;
        break;
      default:
        break;
    }
  }

  limpar() {
    this.primeiroNumero = 0;
    this.segundoNumero = 0;
    this.resultado = 0;
  }

}
