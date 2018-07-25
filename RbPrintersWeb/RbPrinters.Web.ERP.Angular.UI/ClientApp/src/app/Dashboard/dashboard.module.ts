import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { DashboardComponent } from './dashboard.component';
import { SideNavComponent } from '../Shared/side-nav/side-nav.component';
import { TopNavComponent } from '../Shared/top-nav/top-nav.component';

 

@NgModule({
  declarations: [
    HomeComponent,
    DashboardComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: '', component: HomeComponent },
      { path: 'top-nav', component: TopNavComponent },
      { path: 'side-nav', component: SideNavComponent },
      { path: 'dashboard', component: DashboardComponent },





    ])

  ],
  providers: [],
  bootstrap: [DashboardComponent],
})
export class DeshModule {}
