import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ListComponent } from './components/list/list.component';
import { FormAddComponent } from './components/form-add/form-add.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [AppComponent, ListComponent, FormAddComponent],
  imports: [BrowserModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
