import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent {

  constructor(private router: Router, private authService: AuthService) { }

  login(form: NgForm) {
    this.authService.obterTodosOsUsuarios().subscribe(usuarios => {
      const usuarioValido = this.authService.validarUsuario(usuarios, form.value);
      if (!usuarioValido) {
        alert("Usuário ou senha incorretos!");
        return;
      }
      this.authService.isLoggedIn = true;
      this.router.navigate(['/private/home']);
    });
  }

  goToSignup() {
    this.router.navigate(['/public', 'signup'])
  }

}
