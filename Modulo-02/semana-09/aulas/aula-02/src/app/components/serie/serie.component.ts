import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-serie',
  templateUrl: './serie.component.html',
  styleUrls: ['./serie.component.css']
})
export class SerieComponent implements OnInit {

  serieId: number = 0;

  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    const serieIdString = this.route.snapshot.paramMap.get('id');
    if (serieIdString === null) return;
    this.serieId = parseInt(serieIdString);
  }

}
