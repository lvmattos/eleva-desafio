import { Escola } from 'src/app/model/escola.model';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl } from '@angular/forms';
import { CadastrarEscolaService } from './cadastrar-escola.service';

@Component({
  selector: 'ed-cadastrar-escola',
  templateUrl: './cadastrar-escola.component.html',
  styleUrls: ['./cadastrar-escola.component.scss'],
})
export class CadastrarEscolaComponent implements OnInit {
  form: FormGroup;
  constructor(
    private formBuilder: FormBuilder,
    private cadastrarEscolaService: CadastrarEscolaService
  ) {
    this.NovoForm(formBuilder);
  }

  ngOnInit() {}

  salvarNovaEscola() {
    debugger;
    const escola = {
      nome: this.form.controls.nome.value,
      endereco: this.form.controls.endereco.value,
    } as Escola;
    this.cadastrarEscolaService.cadastrarEscola(escola).subscribe((res) => {
      this.NovoForm(this.formBuilder);
    });
  }

  private NovoForm(formBuilder: FormBuilder) {
    this.form = formBuilder.group({
      nome: '',
      endereco: '',
    });
  }
}
