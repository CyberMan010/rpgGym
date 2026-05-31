import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { environment } from './environments/environment';

if (!environment.production) {
  (window as any)['ngDevMode'] = true;
}

platformBrowserDynamic()
  .bootstrapModule('AppModule')
  .catch(err => console.error(err));
