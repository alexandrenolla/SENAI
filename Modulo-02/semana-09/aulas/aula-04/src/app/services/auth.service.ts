import { Injectable } from '@angular/core';
import { IUsuario } from '../interfaces/IUsuario';
import { HttpClient } from '@angular/common/http';
import { tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  isLoggedIn = false;

  constructor(private httpClient: HttpClient) { }

  cadastrarUsuario(usuario: IUsuario) {
    return this.httpClient.post("http://localhost:3000/usuarios", usuario);
  }

  obterTodosOsUsuarios() {
    return this.httpClient.get<IUsuario[]>("http://localhost:3000/usuarios");
  }

  validarUsuario(usuarios: IUsuario[], usuarioValidar: IUsuario) {
    let usuarioValido = false;
    for (let index = 0; index < usuarios.length; index++) {
      const usuario = usuarios[index];
      const emailValido = usuario.email == usuarioValidar.email;
      const senhaValida = usuario.password == usuarioValidar.password;
      if (emailValido && senhaValida)
        usuarioValido = true; 
    }

    return usuarioValido;
  }
}
