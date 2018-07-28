import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

import { AppComponent } from './app.component';
import { routing } from './app.routing';
import { AppLayoutComponent } from '../_layout/app-layout/app-layout.component';
import { AppHeaderComponent } from '../_layout/app-header/app-header.component';
import { LoginComponent } from '../Login/login.component';
import { DashboardComponent } from '../Dashboard/dashboard.component';
import { ProductWeddingCardComponent } from '../Products/WeddingCard/Products.WeddingCard.Component';
import { AppSidebarComponent } from '../_layout/app-sidebar/app-sidebar.component';
import { AppFooterCpmponent } from '../_layout/app-footer/app-footer.component';
import { HomeComponent } from '../Pages/home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    AppLayoutComponent,
    AppHeaderComponent,
    LoginComponent,
    DashboardComponent,
    ProductWeddingCardComponent,
    AppSidebarComponent,
    AppFooterCpmponent,
    HomeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    AngularFontAwesomeModule,
    FormsModule,
    routing
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
