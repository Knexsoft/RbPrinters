import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, NgModel } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { WebAppComponent } from './webapp.component';
import { AboutComponent } from './About/about.component';
import { HomesComponent } from './Home/home.component';

@NgModule({
  declarations: [
    WebAppComponent,
    AboutComponent,
    HomesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomesComponent, pathMatch: 'full' },
      { path: 'about', component: AboutComponent },
    ])
  ],
  providers: [],
  bootstrap: [WebAppComponent]
})
export class WebAppModule {

}
