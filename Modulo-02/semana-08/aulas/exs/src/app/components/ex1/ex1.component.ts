import { Component } from '@angular/core';

@Component({
  selector: 'exs-ex1',
  templateUrl: './ex1.component.html',
  styleUrls: ['./ex1.component.scss']
})
export class Ex1Component {

  num = 0;

  somar(){
    this.num ++;  
  }
  
  subtrair(){
    this.num--;
  }
}
