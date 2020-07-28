import { MatSliderModule } from '@angular/material/slider';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { APP_ROUTER } from './app.routes';
import { HttpClientModule } from '@angular/common/http';
import { AppCustomPreloader } from './app.custompreloader';
import { SharedModule } from './shared/shared.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpService } from './core/http-request/http.service';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    APP_ROUTER,
    BrowserModule,
    CommonModule,
    HttpModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    SharedModule.forRoot(),
    AppRoutingModule,
    BrowserAnimationsModule,
    NgbModule,
    MatSliderModule
  ],
  providers: [AppCustomPreloader, HttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
