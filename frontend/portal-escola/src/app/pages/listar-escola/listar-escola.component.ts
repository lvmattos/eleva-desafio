import { Component, OnInit } from '@angular/core';
import { Escola } from 'src/app/model/escola.model';
import { ListarEscolaService } from './listar-escola.service';

@Component({
  selector: 'ed-listar-escola',
  templateUrl: './listar-escola.component.html',
  styleUrls: ['./listar-escola.component.scss'],
})
export class ListarEscolaComponent implements OnInit {
  escolaList: Array<Escola> = [];

  constructor(private listarEscolaService: ListarEscolaService) {}

  ngOnInit() {
    this.escolaList = new Array<Escola>();
    this.listarEscolaService.getlAllEscola().subscribe((res: Array<Escola>) => {
      this.escolaList = res;
    });
  }
}
