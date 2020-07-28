import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'ed-side-bar',
  templateUrl: './side-bar.component.html',
  styleUrls: ['./side-bar.component.scss'],
})
export class SideBarComponent implements OnInit {
  constructor(private router: Router) {}

  ngOnInit() {}

  showCadastrarEscola() {
    this.router.navigate(['/cadastrar-escola']);
  }

  showListarEscola() {
    this.router.navigate(['/listar-escola']);
  }

  showCadastrarTurma() {}

  showListarTurma() {}
}
