import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AlunoListComponent } from './components/aluno-list/aluno-list.component';

@NgModule({
  declarations: [
    AppComponent,
    AlunoListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
