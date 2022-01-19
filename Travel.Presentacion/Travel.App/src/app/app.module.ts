import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AutorViewComponent } from './autor-view/autor-view.component';
import { LibroViewComponent } from './libro-view/libro-view.component';
import { AutorLibroViewComponent } from './autor-libro-view/autor-libro-view.component';
import { EditorialViewComponent } from './editorial-view/editorial-view.component';

@NgModule({
  declarations: [
    AppComponent,
    AutorViewComponent,
    LibroViewComponent,
    AutorLibroViewComponent,
    EditorialViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
