import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent {

  constructor(private router: Router, private authService: AuthService) { }

  goToSignin() {
    this.router.navigate(['/public', 'signin'])
  }

  onSubmit(form: NgForm) {
    this.authService.cadastrarUsuario(form.value).subscribe(resposta => {
      this.authService.isLoggedIn = true;
      this.router.navigate(['/private/home']);
    });
  }

}
