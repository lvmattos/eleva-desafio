import { RouterModule, Routes } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';
import { AppCustomPreloader } from './app.custompreloader';

const APP_ROUTES: Routes = [
  {
    path: '',
    canActivate: [],
    canActivateChild: [],
    pathMatch: 'full',
    loadChildren: () =>
      import('src/app/pages/home/home.module').then((m) => m.HomeModule),
  },
  {
    path: 'cadastrar-escola',
    canActivate: [],
    canActivateChild: [],
    pathMatch: 'full',
    loadChildren: () =>
      import('src/app/pages/cadastrar-escola/cadastrar-escola.module').then(
        (m) => m.CadastrarEscolaModule
      ),
  },
  {
    path: 'listar-escola',
    canActivate: [],
    canActivateChild: [],
    pathMatch: 'full',
    loadChildren: () =>
      import('src/app/pages/listar-escola/listar-escola.module').then(
        (m) => m.ListarEscolaModule
      ),
  },
];

export const APP_ROUTER: ModuleWithProviders = RouterModule.forRoot(
  APP_ROUTES,
  { preloadingStrategy: AppCustomPreloader }
);
