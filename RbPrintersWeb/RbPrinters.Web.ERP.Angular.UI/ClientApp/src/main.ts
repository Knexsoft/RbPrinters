import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { environment } from './environments/environment';
import { AppModule } from './app/Shared/app.module';

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}

const providers = [
  { provide: 'BASE_URL', useFactory: getBaseUrl, deps: [] }
];

if (environment.production) {
  enableProdMode();
}

//enableProdMode();

platformBrowserDynamic(providers).bootstrapModule(AppModule)
  .catch(err => console.log(err));

//platformBrowserDynamic(providers).bootstrapModule(AppModule).then(ref => {
//  // Ensure Angular destroys itself on hot reloads.
//  if (window['ngRef']) {
//    window['ngRef'].destroy();
//  }
//  window['ngRef'] = ref;

//  // Otherise, log the boot error
//})
//  .catch(err => console.log(err));

 


