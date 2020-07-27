import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import CalculatorService from './shared/api/Calculator.Service';
import { CalculatorComponent } from './shared/components/Calculator.Component';

@NgModule({
  declarations: [
    AppComponent,
    CalculatorComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: CalculatorComponent, pathMatch:'full' },
      { path: 'CalculatorService', component: CalculatorService },
    ])
  ],
  providers: [HttpClientModule, CalculatorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
