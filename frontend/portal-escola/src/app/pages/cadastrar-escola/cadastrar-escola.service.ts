import { Escola } from 'src/app/model/escola.model';
import { HttpService } from './../../core/http-request/http.service';
import { Injectable } from '@angular/core';

const BASE_URL = 'Escola';

@Injectable({
  providedIn: 'root',
})
export class CadastrarEscolaService {
  constructor(private httpService: HttpService) {}

  cadastrarEscola(escola: Escola) {
    return this.httpService.post(BASE_URL, escola);
  }
}
