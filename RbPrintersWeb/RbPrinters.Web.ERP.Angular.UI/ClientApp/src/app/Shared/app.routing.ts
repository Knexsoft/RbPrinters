import { Routes, RouterModule } from '@angular/router';
import { AppLayoutComponent } from '../_layout/app-layout/app-layout.component';
import { DashboardComponent } from '../Dashboard/dashboard.component';
import { LoginComponent } from '../Login/login.component';

//Products
import { ServicesWeddingCardComponent } from '../Services/WeddingCard/Services.WeddingCard.Component';


const appRoutes: Routes = [

  //Site routes goes here 
  //{ 
  //    path: '', 
  //    component: SiteLayoutComponent,
  //    children: [
  //      { path: '', component: HomeComponent, pathMatch: 'full'},
  //      { path: 'about', component: AboutComponent },
  //      { path: 'test/:id', component: AboutComponent }
  //    ]
  //},

  // App routes goes here here
  {
    path: '',
    component: AppLayoutComponent,
    children: [
      { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'services/wedding-cards', component: ServicesWeddingCardComponent },

    ]
  },

  //no layout routes
  { path: 'login', component: LoginComponent },
  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);


