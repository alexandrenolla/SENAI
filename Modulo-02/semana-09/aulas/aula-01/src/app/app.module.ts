import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ExemploLifecycleComponent } from './components/exemplo-lifecycle/exemplo-lifecycle.component';
import { SerieComponent } from './components/serie/serie.component';
import { ListaEpisodiosComponent } from './components/lista-episodios/lista-episodios.component';

@NgModule({
  declarations: [
    AppComponent,
    ExemploLifecycleComponent,
    SerieComponent,
    ListaEpisodiosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
