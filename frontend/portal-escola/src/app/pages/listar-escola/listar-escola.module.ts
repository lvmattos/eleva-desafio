import { NgModule } from '@angular/core';
import { RouterModule} from '@angular/router';
import { ListarEscolaComponent } from './listar-escola.component';
import { LISTAR_ESCOLA_ROUTES } from './listar-escola.routes';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(LISTAR_ESCOLA_ROUTES)
  ],
  declarations: [ListarEscolaComponent],
  exports: [RouterModule],
  providers: [],
  entryComponents: [],
})
export class ListarEscolaModule {}
