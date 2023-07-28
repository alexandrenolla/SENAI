import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AlunoFormComponent } from './aluno-form/aluno-form.component';
import { CursoFormComponent } from './curso-form/curso-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ProdutoFormComponent } from './produto-form/produto-form.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AlunoFormComponent,
    CursoFormComponent,
    ProdutoFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
