import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ContadorComponent } from './components/contador/contador.component';
import { InputBotaoValorComponent } from './components/input-botao-valor/input-botao-valor.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [AppComponent, ContadorComponent, InputBotaoValorComponent],
  imports: [BrowserModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
