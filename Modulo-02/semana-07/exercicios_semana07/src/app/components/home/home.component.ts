import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  textoDigitado = '';
  primeiroNumero = 0;
  segundoNumero = 0;
  operacao = 'Somar';
  resultado = 0;

  Calcular() {
    switch (this.operacao) {
      case 'Somar':
        this.resultado = this.primeiroNumero + this.segundoNumero;
        break;
      case 'Diminuir':
        this.resultado = this.primeiroNumero - this.segundoNumero;
        break;
      case 'Multiplicar':
        this.resultado = this.primeiroNumero * this.segundoNumero;
        break;
      case 'Dividir':
        this.resultado = this.primeiroNumero / this.segundoNumero;  
        break;
      default:
        break;
    }
  }

  Limpar() {
    this.primeiroNumero = 0;
    this.segundoNumero = 0;
    this.resultado = 0; 
  }
}
