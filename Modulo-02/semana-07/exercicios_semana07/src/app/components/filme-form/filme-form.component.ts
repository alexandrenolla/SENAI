import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-filme-form',
  templateUrl: './filme-form.component.html',
  styleUrls: ['./filme-form.component.css']
})
export class FilmeFormComponent {

  filmeForm: FormGroup;

  constructor() {
    this.filmeForm = new FormGroup({
      'nome': new FormControl('', [Validators.required, Validators.minLength(3)]),
      'email': new FormControl('', [Validators.required, Validators.email]),
      'filme': new FormControl("", [Validators.required, Validators.minLength(3)]),
      'nota': new FormControl(null, [Validators.required, Validators.min(1),Validators.max(10)])
  })
  }

  Enviar() {
    alert(`Você avaliou o filme ${this.filmeForm.get('filme')?.value}`);
  }
}
