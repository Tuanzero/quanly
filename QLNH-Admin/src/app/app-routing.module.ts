import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { NhaHangComponent } from './nha-hang/nha-hang.component';
import { VaiTroComponent } from './vai-tro/vai-tro.component';



const routes: Routes = [
  { path: 'NhaHang', component: NhaHangComponent},
  { path: 'VaiTro', component: VaiTroComponent},
  { path: '', component: HomeComponent},
  { path: '**', component: PageNotFoundComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
