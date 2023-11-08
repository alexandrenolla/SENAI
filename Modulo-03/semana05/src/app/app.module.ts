import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModalComponent } from './modal/modal.component';
import { HomeModule } from './home/home/home.module';
import { SharedModule } from './shared/shared.module';
import { ExerciciosTrelloComponent } from './exercicios-trello/exercicios-trello.component';

@NgModule({
  declarations: [
    AppComponent,
    ModalComponent,
    ExerciciosTrelloComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HomeModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
