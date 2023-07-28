import { Component } from '@angular/core';

@Component({
  selector: 'app-meu-primeiro-componente',
  template: ` <p>Componente Filho</p> `,
  styles: [
    `
      p {
        color: green;
      }
    `,
  ],
})
export class MeuPrimeiroComponenteComponent {}
