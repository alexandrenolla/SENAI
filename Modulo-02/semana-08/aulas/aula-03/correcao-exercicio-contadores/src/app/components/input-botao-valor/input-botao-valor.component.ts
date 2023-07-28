import { Component } from '@angular/core';

@Component({
  selector: 'app-input-botao-valor',
  templateUrl: './input-botao-valor.component.html',
  styleUrls: ['./input-botao-valor.component.scss'],
})
export class InputBotaoValorComponent {
  valorPix = 10.0;

  incrementar(value: number) {
    this.valorPix += value;
  }

  incrementarLabel($event: any) {
    let value = +$event.target?.innerText;
    this.valorPix += value;
  }
}
