import { CadastrarEscolaComponent } from './cadastrar-escola.component';
import { Routes } from '@angular/router';

export const CADASTRAR_ESCOLA_ROUTES: Routes = [
  {
    path: '',
    component: CadastrarEscolaComponent,
    pathMatch: 'full',
  },
];
