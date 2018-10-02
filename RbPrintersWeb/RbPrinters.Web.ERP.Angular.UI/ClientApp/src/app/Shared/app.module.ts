import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { CommonModule } from '@angular/common';

import { AppComponent } from './app.component';
import { routing } from './app.routing';
import { AppLayoutComponent } from '../_layout/app-layout/app-layout.component';
import { AppHeaderComponent } from '../_layout/app-header/app-header.component';
import { LoginComponent } from '../Login/login.component';
import { DashboardComponent } from '../Dashboard/dashboard.component';
import { AppSidebarComponent } from '../_layout/app-sidebar/app-sidebar.component';
import { AppFooterCpmponent } from '../_layout/app-footer/app-footer.component';
import { ServicesWeddingCardComponent } from '../Services/WeddingCard/Services.WeddingCard.Component';
import { UserService } from './Services/User.Service';

@NgModule({
  declarations: [
    AppComponent,
    AppLayoutComponent,
    AppHeaderComponent,
    LoginComponent,
    DashboardComponent,
    ServicesWeddingCardComponent,
    AppSidebarComponent,
    AppFooterCpmponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    CommonModule,
    AngularFontAwesomeModule,
    FormsModule,
    routing
  ],
  providers: [UserService],
  bootstrap: [AppComponent],
})
export class AppModule { }
