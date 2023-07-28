import { Component } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';

@Component({
  selector: 'app-curso-form',
  templateUrl: './curso-form.component.html',
  styleUrls: ['./curso-form.component.css']
})
export class CursoFormComponent {

  cursoForm: FormGroup;
  cursosProibidos = ['Engenharia', 'Psicologia'];

  constructor() {
    this.cursoForm = new FormGroup({
      'nomeCurso': new FormControl('Insira o nome do curso', [Validators.required, this.cursosProibidosValidator()]),
      'emailCoordenador': new FormControl('', [Validators.required, Validators.email]),
      'categoriaCurso': new FormControl('graduacao') 
    });
  }

  onSubmit() {
    console.log(this.cursoForm.get('nomeCurso')?.value);
    console.log(this.cursoForm.get('emailCoordenador')?.value);
    console.log(this.cursoForm.get('categoriaCurso')?.value); 
  }

  cursosProibidosValidator(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      if (this.cursosProibidos.includes(control.value)) {
        return { 'cursoProibido': true };
      } else {
        return null;
      }
    }
  }

}
