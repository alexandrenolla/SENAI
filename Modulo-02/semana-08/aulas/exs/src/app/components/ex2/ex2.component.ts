import { Component } from '@angular/core';

@Component({
  selector: 'exs-ex2',
  templateUrl: './ex2.component.html',
  styleUrls: ['./ex2.component.scss']
})
export class Ex2Component {
  num = 0;

  incrementar(valor:number){
     this.num = this.num + valor;
    return this.num;
  }

  incrementarLabel($event:any){
    let valor = +$event.target?.innerText;
    this.num = this.num + valor;
 }
}
