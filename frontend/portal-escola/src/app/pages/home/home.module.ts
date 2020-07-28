import { NgModule } from '@angular/core';
import { RouterModule} from '@angular/router';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { HOME_ROUTES } from './home.routes';

@NgModule({
  imports: [
    RouterModule.forChild(HOME_ROUTES)
  ],
  declarations: [HomeComponent],
  exports: [RouterModule],
  providers: [],
  entryComponents: [],
})
export class HomeModule {}
