import { inject } from '@angular/core';
import { CanActivateFn, CanDeactivateFn } from '@angular/router';
import { AuthService } from '../services/auth.service';

export const acessarAutenticacaoGuard: CanActivateFn = (route, state) => {  
  if (inject(AuthService).isLoggedIn)
    return false;
  else
    return true;
};

export const acessarModuloPrivadoGuard: CanActivateFn = (route, state) => {
  return inject(AuthService).isLoggedIn;
}
