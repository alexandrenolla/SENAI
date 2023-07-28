import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PrivateComponent } from 'src/app/layouts/private/private.component';
import { HomeComponent } from './home/home.component';
import { SerieComponent } from './serie/serie.component';

const routes: Routes = [
  {
    path: '',
    component: PrivateComponent,
    children: [
      { path: 'home', component: HomeComponent },
      { path: 'serie/:id', component: SerieComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PrivateRoutingModule { }
