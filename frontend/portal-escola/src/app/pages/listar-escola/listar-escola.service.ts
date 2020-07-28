import { HttpService } from './../../core/http-request/http.service';
import { Injectable } from '@angular/core';

const BASE_URL = 'Escola';

@Injectable({
  providedIn: 'root',
})
export class ListarEscolaService {
  constructor(private httpService: HttpService) {}

  getlAllEscola() {
    return this.httpService.get(BASE_URL);
  }
}
