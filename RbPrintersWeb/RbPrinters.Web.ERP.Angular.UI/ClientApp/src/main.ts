import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';
import { DeshModule } from './app/Dashboard/dashboard.module';

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}

const providers = [
  { provide: 'BASE_URL', useFactory: getBaseUrl, deps: [] }
];

  enableProdMode();

platformBrowserDynamic(providers).bootstrapModule(AppModule)
  .catch(err => console.log(err));

platformBrowserDynamic(providers).bootstrapModule(DeshModule)
  .catch(err => console.log(err));

 

