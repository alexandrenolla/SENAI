import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PrivateRoutingModule } from './private-routing.module';
import { HomeComponent } from './home/home.component';
import { SerieComponent } from './serie/serie.component';
import { PrivateComponent } from 'src/app/layouts/private/private.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    PrivateComponent,
    HomeComponent,
    SerieComponent
  ],
  imports: [
    CommonModule,
    PrivateRoutingModule,
    SharedModule
  ]
})
export class PrivateModule { }
