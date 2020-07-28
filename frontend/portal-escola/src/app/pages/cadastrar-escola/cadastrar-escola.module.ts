import { CadastrarEscolaComponent } from './cadastrar-escola.component';
import { NgModule } from '@angular/core';
import { RouterModule} from '@angular/router';
import { CADASTRAR_ESCOLA_ROUTES } from './cadastrar-escola.routes';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(CADASTRAR_ESCOLA_ROUTES)
  ],
  declarations: [CadastrarEscolaComponent],
  exports: [RouterModule],
  providers: [],
  entryComponents: [],
})
export class CadastrarEscolaModule {}
