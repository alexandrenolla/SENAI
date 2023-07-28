import { Component } from '@angular/core';

@Component({
  selector: 'app-segundo-componente',
  templateUrl: './segundo-componente.component.html',
  styleUrls: ['./segundo-componente.component.scss'],
})
export class SegundoComponenteComponent {
  idade = 5;
  textoInputIdade = 'Informe sua idade';
  img = {
    altura: 150,
    largura: 150,
    url: 'https://avatars.githubusercontent.com/u/7356079?v=4',
  };
}
