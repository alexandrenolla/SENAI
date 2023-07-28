import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  series = [
    { id: 1, nome: 'Constantine' },
    { id: 2, nome: 'Rome' },
    { id: 3, nome: 'Robot Chicken' },
    { id: 4, nome: 'True Detective' },
    { id: 5, nome: 'Sharp Objects' },
    { id: 6, nome: 'Marvel\'s Runaways' },
    { id: 7, nome: 'Atypical' },
    { id: 8, nome: 'Spartacus' },
  ];

  constructor(private router: Router, private route: ActivatedRoute) { }

  recebeClickAssistir(serie: any) {
    this.router.navigate([ '..', 'serie', serie.id], { relativeTo: this.route });
  }
}
