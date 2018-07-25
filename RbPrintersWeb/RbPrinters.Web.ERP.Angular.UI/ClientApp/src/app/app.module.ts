import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './Shared/nav-menu/nav-menu.component';
import { DashboardComponent } from './Dashboard/dashboard.component';
import { LoginComponent } from './Login/login.component';
import { SideNavComponent } from './Shared/side-nav/side-nav.component';
import { TopNavComponent } from './Shared/top-nav/top-nav.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    LoginComponent,
    SideNavComponent,
    TopNavComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent, },
      { path: 'top-nav', component: TopNavComponent },
      { path: 'side-nav', component: SideNavComponent },

      


    ])

  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
