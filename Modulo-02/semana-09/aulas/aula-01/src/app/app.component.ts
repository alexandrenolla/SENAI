import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  valor = 'bom dia';
  flag = true;

  mudarValor() {
    this.valor = this.valor == 'bom dia' ? 'boa noite' : 'bom dia';
  }

  toggleComponente() {
    this.flag = !this.flag;
  }
}
