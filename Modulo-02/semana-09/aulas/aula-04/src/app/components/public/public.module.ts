import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PublicRoutingModule } from './public-routing.module';
import { SigninComponent } from './signin/signin.component';
import { SignupComponent } from './signup/signup.component';
import { PublicComponent } from 'src/app/layouts/public/public.component';
import { SharedModule } from '../shared/shared.module';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    SigninComponent,
    SignupComponent,
    PublicComponent
  ],
  imports: [
    CommonModule,
    PublicRoutingModule,
    FormsModule,
    SharedModule
  ]
})
export class PublicModule { }
