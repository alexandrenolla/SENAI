import { Component } from '@angular/core';
import { isEmpty } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent {
  username: string = "";

  validacaoBotao() {
    if (this.username.length === 0) {
      return true;
    }
    else {
      return false;
    }
  }

  botaoClicado() {
    this.username = "";
  }
}
