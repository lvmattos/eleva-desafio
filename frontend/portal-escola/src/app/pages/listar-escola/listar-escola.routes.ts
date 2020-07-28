import { Routes } from '@angular/router';
import { ListarEscolaComponent } from './listar-escola.component';

export const LISTAR_ESCOLA_ROUTES: Routes = [
  {
    path: '',
    component: ListarEscolaComponent,
    pathMatch: 'full',
  },
];
