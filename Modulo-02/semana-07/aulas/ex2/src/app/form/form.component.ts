import { Component } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent {
  
  projetoForm: FormGroup;
  nomeProibido = 'teste';

  constructor() {
    this.projetoForm = new FormGroup({
      'nomeProjeto': new FormControl('', [Validators.required, this.nomeProibidoValidator()]),
      'email': new FormControl('', [Validators.required, Validators.email]),
      "statusProjeto": new FormControl("", Validators.required)
    })
  }

  onSubmit() {
    console.log(this.projetoForm.get('nomeProjeto')?.value);
    console.log(this.projetoForm.get('email')?.value);
    console.log(this.projetoForm.get('statusProjeto')?.value);
  }

  nomeProibidoValidator(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      if (this.nomeProibido.includes(control.value)) {
        return { 'nomeProibido': true }
      } else {
        return null;
      }
    }
  }
}

