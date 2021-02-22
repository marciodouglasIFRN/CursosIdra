import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CursoComponent } from './curso/curso.component';
import { CartaoComponent } from './cartao/cartao.component';
import { CartaoFormComponent } from './cartao-form/cartao-form.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    CursoComponent,
    CartaoComponent,
    CartaoFormComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'curso', component: CursoComponent, pathMatch: 'full' },
      { path: 'cartao', component: CartaoComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
