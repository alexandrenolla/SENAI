import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-aluno-form',
  templateUrl: './aluno-form.component.html',
  styleUrls: ['./aluno-form.component.css']
})
export class AlunoFormComponent {

  aluno = {
    nome: '',
    email: '',
    curso: ''
  }

  onSubmit() {
    console.log('Valores do forms');
    console.log(this.aluno);
  }
}
