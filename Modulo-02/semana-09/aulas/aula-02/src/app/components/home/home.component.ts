import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  series = [
    { id: 1, nome: 'Serie 1' },
    { id: 2, nome: 'Serie 2' },
    { id: 3, nome: 'Serie 3' },
    { id: 4, nome: 'Serie 4' },
    { id: 5, nome: 'Serie 5' },
    { id: 6, nome: 'Serie 6' },
    { id: 7, nome: 'Serie 7' },
    { id: 8, nome: 'Serie 8' },
  ];
}
