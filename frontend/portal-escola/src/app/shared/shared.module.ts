import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { RouterModule } from '@angular/router';
import { SideBarComponent } from './components/side-bar/side-bar.component';
import {MatSidenavModule} from '@angular/material/sidenav';

@NgModule({
  imports: [CommonModule, RouterModule, MatSidenavModule],
  declarations: [HeaderComponent, SideBarComponent],
  exports: [HeaderComponent, SideBarComponent],
  providers: [],
  entryComponents: [],
})
export class SharedModule {
  static forRoot(): ModuleWithProviders {
    return {
      ngModule: SharedModule,
    };
  }
}
