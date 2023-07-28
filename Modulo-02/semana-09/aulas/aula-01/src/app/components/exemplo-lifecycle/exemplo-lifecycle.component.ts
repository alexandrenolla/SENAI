import { AfterContentChecked, AfterContentInit, AfterViewInit, Component, DoCheck, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-exemplo-lifecycle',
  templateUrl: './exemplo-lifecycle.component.html',
  styleUrls: ['./exemplo-lifecycle.component.css']
})
export class ExemploLifecycleComponent implements OnInit, OnChanges, DoCheck, AfterContentInit, AfterViewInit, OnDestroy{

  @Input() valor: string | null = null;

  constructor() {
    console.log('constructor');
  }

  ngOnInit(): void {
    console.log('ngOnInit');
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log('ngOnChanges')
  }

  ngDoCheck(): void {
    console.log('ngDoCheck');
  }

  ngAfterContentInit(): void {
    console.log('ngAfterContentInit');
  }

  ngAfterViewInit(): void {
    console.log('ngAfterViewInit');
  }

  ngOnDestroy(): void {
    console.log('ngOnDestroy');
  }

}
