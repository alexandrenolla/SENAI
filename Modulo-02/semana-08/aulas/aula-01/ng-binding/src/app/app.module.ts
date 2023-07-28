import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MeuPrimeiroComponenteComponent } from './components/meu-primeiro-componente/meu-primeiro-componente.component';
import { SegundoComponenteComponent } from './components/segundo-componente/segundo-componente.component';

@NgModule({
  declarations: [AppComponent, MeuPrimeiroComponenteComponent, SegundoComponenteComponent],
  imports: [BrowserModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
