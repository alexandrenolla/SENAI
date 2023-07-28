import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  username = '';

  habilitarBotao() {
    if (this.username.length === 0)
      return true;
    else
      return false;
  }

  botaoClickado() {
    this.username = '';
  }

}
