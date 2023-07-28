import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { Ex1Component } from './components/ex1/ex1.component';
import { FormsModule } from '@angular/forms';
import { Ex2Component } from './components/ex2/ex2.component';

@NgModule({
  declarations: [
    AppComponent,
    Ex1Component,
    Ex2Component
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
